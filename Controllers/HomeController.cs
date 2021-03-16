using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DocumentManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using DocumentManagement.Models.ViewModels;

namespace DocumentManagement.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHostingEnvironment hostingEnvironment;

        DocumentManagementContext _context;
        public HomeController(ILogger<HomeController> logger, IHostingEnvironment environment, DocumentManagementContext context)
        {
            _logger = logger;
            hostingEnvironment = environment;
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(CreatePost model)
        {
            // do other validations on your model as needed
            if (model.MyImage != null)
            {
                var uniqueFileName = GetUniqueFileName(model.MyImage.FileName);
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
                var filePath = Path.Combine(uploads, uniqueFileName);
                var ext = Path.GetExtension(model.MyImage.FileName);
                model.MyImage.CopyTo(new FileStream(filePath, FileMode.Create));

                var file = new Models.Document()
                {
                    Name = uniqueFileName,
                    Extension = ext,
                    Path = filePath,
                    User_ID = 4
                };
                _context.Documents.Add(file);
                _context.SaveChanges();
                //to do : Save uniqueFileName  to your db table   
            }
            // to do  : Return something
            return RedirectToAction("Documents", "Home");
        }
        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
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
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
            
            return RedirectToAction("Index");
        }
        public IActionResult Documents()
        {
            IEnumerable<Models.Document> Files = (from file in _context.Documents
                                                  select file).ToList();
            return View(Files);
        }
        public IActionResult PdfViewer(int id)
        {
            Models.Document file = (from item in _context.Documents
                                    where item.Party_ID == id
                                    select item).SingleOrDefault();
            return View(file);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
