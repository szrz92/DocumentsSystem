using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models
{
    public class CreatePost
    {
        public IFormFile MyImage { set; get; }
    }
}
