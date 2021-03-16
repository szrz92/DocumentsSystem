using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models
{
    public class Department
    {
        [Required]
        public string Name { get; set; }
        public int Company_ID { get; set; }
        [Key]
        public int Party_ID { get; set; }
        [ForeignKey("Party_ID")]
        public virtual Party Party { get; set; }
    }
}
