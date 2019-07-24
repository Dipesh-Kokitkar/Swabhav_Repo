using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DepartmentMVCApp.BusinessModel;

namespace DepartmentMVCApp.Models.Employee
{
    public class ShowAllViewModel
    {
        public List<BusinessModel.Employee> EmployeesList { get; set; }
        public int Count { get; set; }
    }
}