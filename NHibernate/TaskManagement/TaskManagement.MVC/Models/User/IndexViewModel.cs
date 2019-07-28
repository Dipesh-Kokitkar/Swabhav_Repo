using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.MVC.Models.User
{
    public class IndexViewModel
    {
        [Required(ErrorMessage ="This can not be Empty")]
        public string Username { get; set; }
        [Required(ErrorMessage = "This can not be Empty")]
        public string Password { get; set; }

        public string Error { get; set; }
    }
}