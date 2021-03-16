using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace DocumentManagement.Models.Utilities
{
    public class DirModel
    {
        public string DirName { get; set; }
        public string CurrentPath { get; set; }
        public DateTime DirAccessed { get; set; }
    }
    public class FileModel
    {
        public string FileName { get; set; }
        public string CurrentPath { get; set; }
        public string FileType { get; set; }
        public string FileSizeText { get; set; }
        public DateTime FileAccessed { get; set; }
    }
    public class ExplorerModel
    {
        public List<DirModel> DirModelList;
        public List<FileModel> FileModelList;
        public List<SelectListItem> ShareTos;

        public String FolderName;
        public String ParentFolderName;
        public String ParentURL;
        public String URL;

        public ExplorerModel(List<DirModel> dirModelList, List<FileModel> fileModelList)
        {
            DirModelList = dirModelList;
            FileModelList = fileModelList;
        }
    }
    public class Utilities
    {
        DocumentManagementContext _context;
        public Utilities(DocumentManagementContext context)
        {
            _context = context;
        }
        public List<DirModel> MapDirs(String realPath)
        { 
            List<DirModel> dirListModel = new List<DirModel>();

            IEnumerable<string> dirList = Directory.EnumerateDirectories(realPath);
            foreach (string dir in dirList)
            {
                DirectoryInfo d = new DirectoryInfo(dir);

                DirModel dirModel = new DirModel
                {
                    DirName = Path.GetFileName(dir),
                    CurrentPath = d.FullName,
                    DirAccessed = d.LastAccessTime
                };

                dirListModel.Add(dirModel);
            }

            return dirListModel;
        }
        public List<FileModel> MapFiles(String realPath)
        {
            List<FileModel> fileListModel = new List<FileModel>();

            IEnumerable<string> fileList = Directory.EnumerateFiles(realPath);
            foreach (string file in fileList)
            {
                FileInfo f = new FileInfo(file);

                FileModel fileModel = new FileModel();

                if (f.Extension.ToLower() != "php" && f.Extension.ToLower() != "aspx"
                    && f.Extension.ToLower() != "asp" && f.Extension.ToLower() != "exe")
                {
                    fileModel.FileName = Path.GetFileName(file);
                    fileModel.CurrentPath = (realPath.Split("wwwroot")[2] + @"\" + fileModel.FileName).Substring(1);
                    fileModel.FileType = f.Extension.ToLower();
                    fileModel.FileAccessed = f.LastAccessTime;
                    fileModel.FileSizeText = (f.Length < 1024) ?
                                    f.Length.ToString() + " B" : f.Length / 1024 + " KB";

                    fileListModel.Add(fileModel);
                }
            }

            return fileListModel;
        }
        public bool CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool DeleteFolder(string path, int partyId)
        {
            if (Directory.Exists(path))
            {
                try
                {
                    List<FileModel> fileList = MapFiles(path);
                    string[] files = Directory.GetFiles(path);
                    string[] dirs = Directory.GetDirectories(path);
                    foreach (string file in files)
                    {
                        FileInfo fileInfo = new FileInfo(file);

                        var document = from doc in _context.Documents
                                       where doc.Name == fileInfo.Name
                                       select doc;

                        int docId = document.FirstOrDefault().Party_ID;

                        var relation = from r in _context.PartyRelationships
                                       where (r.ToParty_ID == docId)
                                       select r;

                        _context.PartyRelationships.RemoveRange(relation);
                        _context.SaveChanges();

                        _context.Documents.RemoveRange(document);
                        _context.SaveChanges();

                        var party = from p in _context.Parties
                                    where p.ID == docId
                                    select p;

                        _context.Parties.RemoveRange(party);
                        _context.SaveChanges();

                        File.SetAttributes(file, FileAttributes.Normal);

                        File.Delete(file);
                    }

                    foreach (string dir in dirs)
                    {
                        DeleteFolder(dir, partyId);
                    }

                    Directory.Delete(path);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
