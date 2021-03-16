using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models.ViewModels
{
    public class DocumentViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Path { get; set; }
        public int User_ID { get; set; }
        public bool Department_Access { get; set; }
        public bool Company_Access { get; set; }
        public int Department_ID { get; set; }
        public int Company_ID { get; set; }
        public IFormFile Doc { set; get; }
        public List<DocumentDetail> DocumentDetails { get; set; }
    }
    public class DocumentDetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Path { get; set; }
        public int User_ID { get; set; }
        public int Department_ID { get; set; }
        public int Company_ID { get; set; }
        public string UploadedBy { get; set; }
        public string DisplayPath { get; set; }
        public string FileType { get; set; }
    }
}
