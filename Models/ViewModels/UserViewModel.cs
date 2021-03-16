using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models.ViewModels
{
    public class UserViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int Role { get; set; }
        public int Company { get; set; }
        public int Department { get; set; }
        public IEnumerable<SelectListItem> Roles { get; set; }
        public IEnumerable<SelectListItem> Companies { get; set; }
        public IEnumerable<SelectListItem> Departments { get; set; }
        public List<UserDetail> UserDetails { get; set; }
    }
    public class UserDetail
    {
        public string UserName { get; set; }
        public string UserRole { get; set; }
    }
}
