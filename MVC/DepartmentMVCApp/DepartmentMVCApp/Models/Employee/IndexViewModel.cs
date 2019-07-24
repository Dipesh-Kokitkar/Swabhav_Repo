using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DepartmentMVCApp.BusinessModel;

namespace DepartmentMVCApp.Models.Employee
{
    public class IndexViewModel
    {
       
        public List<BusinessModel.Employee> EmployeeList { get; set; }
        public int Count { get; set; }
        public Guid Id { get; set; }
        public IndexViewModel()
        {
            EmployeeList = new List<BusinessModel.Employee>();
        }
    }
}