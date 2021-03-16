using DocumentManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please Provide Username", AllowEmptyStrings = false)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Provide Password", AllowEmptyStrings = false)]
        public string Password { get; set; }
        public int Department_ID { get; set; }
        public int Company_ID { get; set; }
        [Key]
        public int Party_ID { get; set; }
        [ForeignKey("Party_ID")]
        public virtual Party Party { get; set; }
    }
}
