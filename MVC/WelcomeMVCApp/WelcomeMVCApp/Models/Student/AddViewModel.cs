using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMVCApp.BusinessModel;

namespace WelcomeMVCApp.Models.Student
{
    public class AddViewModel
    {
        public string StudentRollno { get; set; }
        public string StudentName { get; set; }
        public string StudentCGPA { get; set; }
        public string StudentDOB { get; set; }
        public string StudentLocation { get; set; }
        public string Error { set; get; }
    }
}