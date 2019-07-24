using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentMVCApp.BusinessModel
{
    [Table("EMPLOYEE")]
    public class Employee:Entity
    {
        public string EName { set; get; }
        public double Salary { set; get; }
        public double Comission { set; get; }
        public string DateOfJoin { set; get; }

        public virtual Department Department { get; set; }
    }
}