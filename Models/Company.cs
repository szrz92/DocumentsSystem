using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models
{
    public class Company
    {
        [Required]
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        [Key]
        public int Party_ID { get; set; }
        [ForeignKey("Party_ID")]
        public virtual Party Party { get; set; }
    }
}
