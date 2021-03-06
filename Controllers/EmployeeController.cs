using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DocumentManagement.Models;
using DocumentManagement.Models.Utilities;
using DocumentManagement.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DocumentManagement.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        DocumentManagementContext _context;
        private readonly IHostingEnvironment hostingEnvironment;
        public EmployeeController(DocumentManagementContext context, IHostingEnvironment environment)
        {
            _context = context;
            hostingEnvironment = environment;
        }
        [Authorize(Roles = "Employee")]
        public IActionResult Index()
        {
            DocumentViewModel viewModel = new DocumentViewModel();
            viewModel.DocumentDetails = new List<DocumentDetail>();
            viewModel.DocumentDetails = (from doc in _context.Documents
                                         where (doc.User_ID == (from usr in _context.Users
                                                                where usr.UserName == User.Identity.Name
                                                                select usr.Party_ID).FirstOrDefault())
                                         select new DocumentDetail()
                                         {
                                             ID = doc.Party_ID,
                                             Name = doc.Name,
                                             User_ID = doc.User_ID,
                                             UploadedBy = (from usr in _context.Users where usr.UserName == User.Identity.Name select usr.UserName).SingleOrDefault(),
                                             DisplayPath = doc.Path.Split("wwwroot", StringSplitOptions.None)[2],
                                             FileType = doc.Extension
                                         }).ToList();
            return View(viewModel);
        }

        public IActionResult Drive(string path)
        {
            Utilities utilities = new Utilities(_context);

            var drive = Path.Combine(hostingEnvironment.WebRootPath, "uploads", User.Identity.Name);
            if (!Directory.Exists(drive))
            {
                if (utilities.CreateFolder(drive))
                {
                    TempData["Success"] = "Folder is created successfully";
                    return RedirectToAction("Drive");
                }
                else
                {
                    TempData["Failure"] = "Folder creation failed";
                    return RedirectToAction("Drive");
                }
            }
            else
            {
                string CurrentFolder = User.Identity.Name;
                string parentFolder = User.Identity.Name;
                string parentPath = drive;
                string realPath = drive;

                if (path != null)
                {
                    List<string> pathElements = path.Split("\\").ToList();
                    realPath = Path.Combine(hostingEnvironment.WebRootPath);
                    parentPath = Path.Combine(hostingEnvironment.WebRootPath);
                    foreach (var elem in pathElements)
                    {
                        realPath = Path.Combine(realPath, elem);
                        if (elem != pathElements.LastOrDefault())
                        {
                            parentPath = Path.Combine(parentPath, elem);
                        }

                    }
                    CurrentFolder = pathElements.LastOrDefault();
                    if (CurrentFolder == "uploads")
                    {
                        CurrentFolder = parentFolder;
                        parentPath = realPath;
                        realPath = drive;
                        TempData["Failure"] = "Can't Navigate, You are not authorized to access this folder.";
                    }
                }

                if (System.IO.File.Exists(realPath))
                {

                    var fileBytes = System.IO.File.ReadAllBytes(realPath);

                    return File(fileBytes, "application/force-download");

                }
                else if (Directory.Exists(realPath))
                {
                    List<DirModel> dirListModel = utilities.MapDirs(realPath);

                    List<FileModel> fileListModel = utilities.MapFiles(realPath);

                    ExplorerModel explorerModel = new ExplorerModel(dirListModel, fileListModel);

                    explorerModel.ShareTos = (from usr in _context.Users
                                                  //where usr.Company_ID == (from currentuser in _context.Users
                                                  //                         where currentuser.UserName == User.Identity.Name
                                                  //                         select currentuser.Company_ID).FirstOrDefault()
                                              select new SelectListItem
                                              {
                                                  Value = Convert.ToString(usr.Party_ID),
                                                  Text = usr.UserName
                                              }).ToList();

                    if (path == null)
                    {
                        explorerModel.URL = drive;
                    }
                    else
                    {
                        explorerModel.URL = realPath;
                    }
                    explorerModel.FolderName = CurrentFolder;
                    explorerModel.ParentURL = parentPath;
                    return View(explorerModel);
                }
                else
                {
                    return Content(path + " is not a valid file or directory.");
                }
            }

        }

        [HttpPost]
        public IActionResult CreateDirectory(string name, string path)
        {
            Utilities utilities = new Utilities(_context);
            List<string> pathElements = path.Split("\\").ToList();
            var drive = Path.Combine(hostingEnvironment.WebRootPath);
            foreach (var elem in pathElements)
            {
                drive = Path.Combine(drive, elem);
            }
            drive = Path.Combine(drive, name);
            if (!Directory.Exists(drive))
            {
                if (utilities.CreateFolder(drive))
                {
                    TempData["Success"] = "Folder is created successfully";
                    return RedirectToAction("Drive", new { path = path });
                }
                else
                {
                    TempData["Failure"] = "Folder creation failed";
                    return RedirectToAction("Drive");
                }
            }
            else
            {
                TempData["Failure"] = "Folder already exists";
                return RedirectToAction("Drive");
            }
        }

        public IActionResult DeleteDirectory(string path)
        {
            Utilities utilities = new Utilities(_context);
            List<string> pathElements = path.Split("\\").ToList();
            var drive = Path.Combine(hostingEnvironment.WebRootPath);

            var parentPath = Path.Combine(hostingEnvironment.WebRootPath);

            foreach (var elem in pathElements)
            {
                drive = Path.Combine(drive, elem);
                if (elem != pathElements.LastOrDefault())
                {
                    parentPath = Path.Combine(parentPath, elem);
                }
            }
            if (Directory.Exists(drive))
            {
                if (utilities.DeleteFolder(drive, CurrentUserPartyId()))
                {
                    TempData["Success"] = "Folder is deleted successfully";
                    return RedirectToAction("Drive", new { path = parentPath });
                }
                else
                {
                    TempData["Failure"] = "Folder deletion failed";
                    return RedirectToAction("Drive");
                }
            }
            else
            {
                TempData["Failure"] = "Folder already deleted";
                return RedirectToAction("Drive");
            }
        }

        [HttpPost]
        public JsonResult DeleteDirectoryAJAX(string path)
        {
            Utilities utilities = new Utilities(_context);
            path = path.Replace("\n ", "");
            path = path.Trim();
            if (Directory.Exists(path))
            {
                if (utilities.DeleteFolder(path, CurrentUserPartyId()))
                {
                    TempData["Success"] = "Folder is deleted successfully.";
                    return Json("Folder is deleted successfully");
                }
                else
                {
                    TempData["Failure"] = "Folder deletion failed.";
                    return Json("Folder deletion failed");
                }
            }
            else
            {
                TempData["Failure"] = "Folder already deleted.";
                return Json("Folder already deleted");
            }
        }

        [HttpPost]
        public JsonResult DeleteFileAJAX(string path)
        {
            path = path.Replace("\n ", "");
            path = path.Trim();
            path = Path.Combine(hostingEnvironment.WebRootPath, path);
            if (System.IO.File.Exists(path))
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(path);

                    System.IO.File.SetAttributes(path, FileAttributes.Normal);
                    System.IO.File.Delete(path);

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

                    TempData["Success"] = "File is deleted successfully.";
                    return Json("File is deleted successfully");
                }
                catch (Exception ex)
                {
                    TempData["Failure"] = "File deletion not successful.";
                    return Json(ex.ToString());
                }
            }
            else
            {
                TempData["Failure"] = "File doesn't exist.";
                return Json("File doesn't exist.");
            }
        }
        public IActionResult Share()
        {
            ShareViewModel viewModel = new ShareViewModel
            {
                MyDocuments = from doc in _context.Documents
                              where doc.User_ID == CurrentUserPartyId()
                              select new SelectListItem
                              {
                                  Value = Convert.ToString(doc.Party_ID),
                                  Text = doc.Name
                              },
                ShareTos = from usr in _context.Users
                           where usr.Company_ID == (from currentuser in _context.Users
                                                    where currentuser.UserName == User.Identity.Name
                                                    select currentuser.Company_ID).FirstOrDefault()
                           select new SelectListItem
                           {
                               Value = Convert.ToString(usr.Party_ID),
                               Text = usr.UserName
                           }
            };

            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Share(ShareViewModel viewModel)
        {
            try
            {
                var partyrelationship = new PartyRelationship()
                {
                    FromParty_ID = viewModel.To,
                    FromPartyRole_ID = (from party in _context.Parties where party.ID == viewModel.To select party.PartyRole_Id).FirstOrDefault(),
                    ToParty_ID = viewModel.Doc,
                    ToPartyRole_ID = 8,
                    Relation_Type = "S",
                    CreatedByParty_ID = CurrentUserPartyId()
                };
                _context.PartyRelationships.Add(partyrelationship);
                _context.SaveChanges();
                TempData["Success"] = "File is shared successfully";
                return RedirectToAction("Share");
            }
            catch (Exception)
            {
                TempData["Failure"] = "File is not shared successfully";
                return RedirectToAction("Share");
            }
        }
        public IActionResult ContextShare(int shareTo, string fileName)
        {
            fileName = fileName.Trim();
            try
            {
                var partyrelationship = new PartyRelationship()
                {
                    FromParty_ID = shareTo,
                    FromPartyRole_ID = (from party in _context.Parties where party.ID == shareTo select party.PartyRole_Id).FirstOrDefault(),
                    ToParty_ID = (from doc in _context.Documents where doc.Name == fileName select doc.Party_ID).FirstOrDefault(),
                    ToPartyRole_ID = 8,
                    Relation_Type = "S",
                    CreatedByParty_ID = CurrentUserPartyId()
                };
                bool fileShare = FileShare(partyrelationship);
                if (fileShare)
                {
                    TempData["Success"] = "File is shared successfully";
                }
                else
                {
                    TempData["Failure"] = "File is not shared successfully";
                }
            }
            catch (Exception)
            {
                TempData["Failure"] = "File is not shared successfully";
            }
            return RedirectToAction("Drive");
        }

        public bool FileShare(PartyRelationship partyRelationship)
        {
            try
            {
                _context.PartyRelationships.Add(partyRelationship);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IActionResult Shared()
        {
            DocumentViewModel viewModel = new DocumentViewModel();
            viewModel.DocumentDetails = new List<DocumentDetail>();
            viewModel.DocumentDetails = (from doc in _context.Documents
                                         join rel in _context.PartyRelationships
                                         on doc.Party_ID equals rel.ToParty_ID
                                         where (rel.FromParty_ID == CurrentUserPartyId()) && (rel.Relation_Type == "S")
                                         select new DocumentDetail()
                                         {
                                             ID = doc.Party_ID,
                                             Name = doc.Name,
                                             User_ID = doc.User_ID,
                                             UploadedBy = (from usr in _context.Users where usr.Party_ID == rel.CreatedByParty_ID select usr.UserName).SingleOrDefault(),
                                             DisplayPath = doc.Path.Split("wwwroot", StringSplitOptions.None)[2],
                                             FileType = doc.Extension
                                         }).ToList();
            return View(viewModel);
        }
        [Authorize(Roles = "Employee")]
        [HttpPost]
        public IActionResult Upload(DocumentViewModel viewModel)
        {
            if (viewModel.Doc != null)
            {
                try
                {
                    var uniqueFileName = GetUniqueFileName(viewModel.Doc.FileName);
                    var uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
                    var filePath = Path.Combine(uploads, uniqueFileName);
                    var ext = Path.GetExtension(viewModel.Doc.FileName);

                    Service service = new Service();
                    if (service.GetFileTypes().Contains(ext))
                    {
                        viewModel.Doc.CopyTo(new FileStream(filePath, FileMode.Create));

                        int partyid = NextPartyID();

                        var party = new Party()
                        {
                            PartyRole_Id = 8
                        };


                        var partyrelationship = new PartyRelationship()
                        {
                            FromParty_ID = CurrentUserPartyId(),
                            FromPartyRole_ID = CurrentUserRoleID(),
                            ToParty_ID = partyid,
                            ToPartyRole_ID = 8,
                            Relation_Type = "U",
                            CreatedByParty_ID = CurrentUserPartyId()
                        };

                        var file = new Document()
                        {
                            Party_ID = partyid,
                            Name = uniqueFileName,
                            Extension = ext,
                            Path = filePath,
                            User_ID = (from usr in _context.Users where usr.UserName == User.Identity.Name select usr.Party_ID).SingleOrDefault(),
                            Company_ID = 0,
                            Department_ID = 0
                        };
                        _context.Parties.Add(party);
                        _context.SaveChanges();
                        _context.PartyRelationships.Add(partyrelationship);
                        _context.SaveChanges();
                        _context.Documents.Add(file);
                        _context.SaveChanges();

                        TempData["Success"] = "File uploaded successfully";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["Failure"] = "File type is not supported!";
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception)
                {
                    TempData["Failure"] = "File is not uploaded. Please try again or contact system administrator!";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["Failure"] = "Please attach the file correctly!";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult UploadIt(IFormFile file, string address)
        {
            if (file != null)
            {
                try
                {
                    var uniqueFileName = GetUniqueFileName(file.FileName);
                    var uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads", User.Identity.Name);
                    if (address != null)
                    {
                        uploads = address;
                    }
                    var filePath = Path.Combine(uploads, uniqueFileName);
                    var ext = Path.GetExtension(file.FileName);
                    if (ext == ".txt")
                    {
                        TempData["Failure"] = "File type is not supported!";
                        return RedirectToAction("Index");
                    }
                    FileStream fileStream = new FileStream(filePath, FileMode.Create);
                    file.CopyTo(fileStream);
                    fileStream.Close();

                    int partyid = NextPartyID();

                    var party = new Party()
                    {
                        PartyRole_Id = 8
                    };


                    var partyrelationship = new PartyRelationship()
                    {
                        FromParty_ID = CurrentUserPartyId(),
                        FromPartyRole_ID = CurrentUserRoleID(),
                        ToParty_ID = partyid,
                        ToPartyRole_ID = 8,
                        Relation_Type = "U",
                        CreatedByParty_ID = CurrentUserPartyId()
                    };

                    var files = new Document()
                    {
                        Party_ID = partyid,
                        Name = uniqueFileName,
                        Extension = ext,
                        Path = filePath,
                        User_ID = (from usr in _context.Users where usr.UserName == User.Identity.Name select usr.Party_ID).SingleOrDefault(),
                        Company_ID = 0,
                        Department_ID = 0
                    };
                    _context.Parties.Add(party);
                    _context.SaveChanges();
                    _context.PartyRelationships.Add(partyrelationship);
                    _context.SaveChanges();
                    _context.Documents.Add(files);
                    _context.SaveChanges();

                    TempData["Success"] = "File uploaded successfully";
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    TempData["Failure"] = "File is not uploaded. Please try again or contact system administrator!";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["Failure"] = "Please attach the file correctly!";
                return RedirectToAction("Index");
            }
        }
        [Authorize(Roles = "SuperAdmin,CompanyAdmin,DepartmentHead,Employee")]
        public IActionResult Documents(int employeeID)
        {
            DocumentViewModel viewModel = new DocumentViewModel();
            viewModel.DocumentDetails = new List<DocumentDetail>();
            viewModel.DocumentDetails = (from doc in _context.Documents
                                         where (doc.User_ID == employeeID)
                                         select new DocumentDetail()
                                         {
                                             ID = doc.Party_ID,
                                             Name = doc.Name,
                                             User_ID = doc.User_ID
                                         }).ToList();
            return View(viewModel);
        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }

        #region Setup
        public int CurrentUserId()
        {
            return (from currentuser in _context.Users
                    where currentuser.UserName == User.Identity.Name
                    select currentuser.Party_ID).FirstOrDefault();
        }
        public int CheckPartyRole(int partyId)
        {
            return (from party in _context.Parties
                    where party.ID == partyId
                    select party.PartyRole_Id).FirstOrDefault();
        }
        public int PartyIdToCompanyId(int partyId)
        {
            return (from party in _context.Companies
                    where party.Party_ID == partyId
                    select party.Party_ID).FirstOrDefault();
        }
        public int CurrentUserPartyId()
        {
            return (from currentuser in _context.Users
                    where currentuser.UserName == User.Identity.Name
                    select currentuser.Party_ID).FirstOrDefault();
        }
        public int CurrentUserRoleID()
        {
            return (from currentuser in _context.Users
                    join currentparty in _context.Parties on currentuser.Party_ID equals currentparty.ID
                    where currentuser.UserName == User.Identity.Name
                    select currentparty.PartyRole_Id).FirstOrDefault();
        }
        public int NextPartyID()
        {
            int partyid = 1;
            try
            {
                partyid = _context.Parties.Max(i => i.ID) + 1;
            }
            catch (Exception ex)
            {
                partyid = 1;
            }
            return partyid;
        }
        public User GetUser(int partyId)
        {
            return (from user in _context.Users
                    where user.Party_ID == partyId
                    select user).SingleOrDefault();
        }
        public Company GetCompany(int partyId)
        {
            return (from company in _context.Companies
                    where company.Party_ID == partyId
                    select company).SingleOrDefault();
        }
        #endregion
    }
}
