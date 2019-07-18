using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace WelcomeMVCApp.Models.Registration
{
    public class IndexViewModel
    {
        [Required(ErrorMessage ="Name Must Reuired")]
        public string Name { get; set; }

        [Range(18,50,ErrorMessage ="Age must between 18 to 50")]
        public int Age { get; set; }

        [Range(10000,50000,ErrorMessage ="Salary must in between 10k to 50k")]
        public double Salary { get; set; }

        [EmailAddress(ErrorMessage ="Email address is invalid")]
        public string Email { get; set; }

        public string SucessMessage { get; set; }
    }
}