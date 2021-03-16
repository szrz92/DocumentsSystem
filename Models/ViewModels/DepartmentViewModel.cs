using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models.ViewModels
{
    public class DepartmentViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<DepartmentDetail> DepartmentDetails { get; set; }
    }
    public class DepartmentDetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Company_ID { get; set; }
    }
}
