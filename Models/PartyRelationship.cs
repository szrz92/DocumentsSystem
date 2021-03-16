using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models
{
    public class PartyRelationship
    {
        [Key]
        public int ID { get; set; }
        public int ToParty_ID { get; set; }
        public int FromParty_ID { get; set; }
        public int ToPartyRole_ID { get; set; }
        public int FromPartyRole_ID { get; set; }
        public int CreatedByParty_ID { get; set; }
        public string Relation_Type { get; set; }
    }
}
