using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.MVC.Models.User
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="This can not be Empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This can not be Empty")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Not Match with password")]
        public string Confirmpaswword { get; set; }
        [Phone(ErrorMessage ="Invalid Mobile Number")]
        public string MobileNumber { get; set; }
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }
    }
}