using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeMVCApp.BusinessModel
{
    public class Employee
    {
        public string Empno { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public string MGR { get; set; }
        public string Hiredate { get; set; }
        public string Salary { get; set; }
        public string Commission { get; set; }
        public string DeptNo { get; set; }

    }
}