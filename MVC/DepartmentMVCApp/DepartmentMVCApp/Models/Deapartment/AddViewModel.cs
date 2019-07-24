using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DepartmentMVCApp.Models.Deapartment
{
    public class AddViewModel
    {
        [Required(ErrorMessage ="This filed required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This filed required")]
        public string Location { get; set; }
    }
}