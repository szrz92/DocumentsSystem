using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models
{
    public class Document
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Extension { get; set; }
        [Required]
        public string Path { get; set; }
        [Required]
        public int User_ID { get; set; }
        [Required]
        public int Department_ID { get; set; }
        [Required]
        public int Company_ID { get; set; }
        [Key]
        public int Party_ID { get; set; }
        [ForeignKey("Party_ID")]
        public virtual Party Party { get; set; }
    }

}
