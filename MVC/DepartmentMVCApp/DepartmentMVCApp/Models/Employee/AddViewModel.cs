using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DepartmentMVCApp.Models.Employee
{
    public class AddViewModel
    {
        [Required(ErrorMessage ="This can not be Empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This can not be Empty")]
        public string Salary { get; set; }
        [Required(ErrorMessage = "This can not be Empty")]
        public string Comission { get; set; }
        [Required(ErrorMessage = "This can not be Empty")]
        public string DateofJoin { get; set; }
        
        public Guid Id { get; set; }
        public string SelectedDepartment { get; set; }
        public string[] departments { get; set; }
    }
}