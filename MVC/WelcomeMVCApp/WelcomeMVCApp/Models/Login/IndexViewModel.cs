using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WelcomeMVCApp.Models.Login
{
    public class IndexViewModel
    {
        [Required(ErrorMessage ="Username required")]
        public string Username { set; get; }

        [CustomPasswordValidator]
        public string Password { set; get; }
    }
}