using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models.ViewModels
{
    public class ShareViewModel
    {
        public int Doc { get; set; }
        public int To { get; set; }
        public IEnumerable<SelectListItem> MyDocuments { get; set; }
        public IEnumerable<SelectListItem> ShareTos { get; set; }
    }
}
