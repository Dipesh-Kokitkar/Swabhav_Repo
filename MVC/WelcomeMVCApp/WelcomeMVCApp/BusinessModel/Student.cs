using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WelcomeMVCApp.BusinessModel
{
    [Table("STUDENT")]
    public class Student
    {
        [Key]
        public int Rollno { get; set; }
        public string Name { get; set; }
        public double CGPA { get; set; }
        public DateTime Birthdate { get; set; }
        public string Location { get; set; }
    }
}