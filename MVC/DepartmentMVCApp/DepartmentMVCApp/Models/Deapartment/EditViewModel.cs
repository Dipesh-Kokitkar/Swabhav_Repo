using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DepartmentMVCApp.Models.Deapartment
{
    public class EditViewModel
    {
        [Required(ErrorMessage = "This can not be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This can not be empty")]
        public string Location { get; set; }

        public Guid Id { get; set; }
    }
}