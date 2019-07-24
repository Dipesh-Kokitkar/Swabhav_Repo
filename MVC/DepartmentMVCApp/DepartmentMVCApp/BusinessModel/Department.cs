using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentMVCApp.BusinessModel
{
    [Table("DEPARTMENT")]
    public class Department:Entity
    {
        public string Dname { get; set; }
        public string Location { get; set; }

        public virtual List<Employee> Employees { get; set; }

        public Department() {
            Employees = new List<Employee>();
        }
    }
}