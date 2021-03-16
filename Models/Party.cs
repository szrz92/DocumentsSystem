using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models
{
    public class Party
    {
        [Key]
        public int ID { get; set; }

        //Foreign key for Party Role
        public int PartyRole_Id { get; set; }
        [ForeignKey("PartyRole_Id")]
        public virtual PartyRole PartyRole { get; set; }
    }
}
