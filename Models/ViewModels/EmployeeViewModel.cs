using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public string UserName { get; set; }
        public int Department_ID { get; set; }
        public int Company_ID { get; set; }
        public List<EmployeeDetail> EmployeeDetails { get; set; }
    }
    public class EmployeeDetail
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public int Department_ID { get; set; }
        public int Company_ID { get; set; }
    }
}
