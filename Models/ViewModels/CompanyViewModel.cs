using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models.ViewModels
{
    public class CompanyViewModel
    {
        [Required]
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<CompanyDetail> CompanyDetails { get; set; }
    }
    public class CompanyDetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
