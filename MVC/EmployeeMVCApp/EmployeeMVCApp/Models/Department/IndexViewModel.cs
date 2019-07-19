using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeMVCApp.Models.Department
{
    public class IndexViewModel
    {
        public Departments SelectedDepartment { get; set; }
        public List<BusinessModel.Employee> FilterList { get; set; }
    }
    public enum Departments { ACCOUNTING, RESEARCH, SALES, OPERATIONS };
}