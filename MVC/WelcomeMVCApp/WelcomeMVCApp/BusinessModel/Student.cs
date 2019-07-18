using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelcomeMVCApp.BusinessModel
{
    public class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public double CGPA { get; set; }
        public DateTime Birthdate { get; set; }
        public string Location { get; set; }
    }
}