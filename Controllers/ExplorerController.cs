using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DocumentManagement.Models;
using DocumentManagement.Models.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;

namespace DocumentManagement.Controllers
{
    public class ExplorerController : Controller
    {
        DocumentManagementContext _context;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IHttpContextAccessor httpcontextaccessor;
        public ExplorerController(DocumentManagementContext context, IHostingEnvironment environment, IHttpContextAccessor _httpcontextaccessor)
        {
            _context = context;
            hostingEnvironment = environment;
            httpcontextaccessor = _httpcontextaccessor;
        }
        public string showURL(IHttpContextAccessor httpcontextaccessor1)
        {
            var request = httpcontextaccessor.HttpContext.Request;

            var absoluteUri = string.Concat(
                        request.Scheme,
                        "://",
                        request.Host.ToUriComponent(),
                        request.PathBase.ToUriComponent()
                        );
            return absoluteUri;
        }
        [HttpPost]
        public IActionResult UploadIt(IFormFile file)
        {
            showURL(httpcontextaccessor);
            if (file != null)
            {
                try
                {
                    var uniqueFileName = GetUniqueFileName(file.FileName);
                    var uploads = Path.Combine(showURL(httpcontextaccessor), "uploads");
                    var filePath = Path.Combine(uploads, uniqueFileName);
                    var ext = Path.GetExtension(file.FileName);
                    if (ext == ".txt")
                    {
                        TempData["Failure"] = "File type is not supported!";
                        return RedirectToAction("Index");
                    }
                    file.CopyTo(new FileStream(filePath, FileMode.Create));


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
        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }
        public IActionResult Index(string path)
        {
            var folderPath = hostingEnvironment.ContentRootPath + "\\wwwroot\\";
            // or folderPath = "FullPath of the folder on server" 
            string[] a;
            string CurrentFolder = "Root";
            string parentPath = "/";
            if (path != null)
            {
                a = path.Split("\\");
                CurrentFolder = a.Last();
                for (int i = 0; i < a.Length - 1; i++)
                {
                    parentPath += a[i] + "/";
                }
            }
            var realPath = folderPath + path;

            if (System.IO.File.Exists(realPath))
            {

                var fileBytes = System.IO.File.ReadAllBytes(realPath);

                //http://stackoverflow.com/questions/1176022/unknown-file-type-mime
                return File(fileBytes, "application/force-download");

            }
            else if (Directory.Exists(realPath))
            {
                Utilities utilities = new Utilities(_context);
                List<DirModel> dirListModel = utilities.MapDirs(realPath);

                List<FileModel> fileListModel = utilities.MapFiles(realPath);

                ExplorerModel explorerModel = new ExplorerModel(dirListModel, fileListModel);

                //For using browser ability to correctly browsing the folders,
                //Every path needs to end with slash
                if (realPath.Last() != '/' && realPath.Last() != '\\')
                { explorerModel.URL = /*"/Explorer/" +*/ path + "/"; }
                else
                { 
                    explorerModel.URL = /*"/Explorer/" +*/ path; 
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
}
