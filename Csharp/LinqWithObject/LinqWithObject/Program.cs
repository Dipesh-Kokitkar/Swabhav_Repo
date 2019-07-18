using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student {Firstname="Sanal",CGPA=9,Location="Raigad" };
            var s2 = new Student {Firstname="Dhurv",CGPA=8.5,Location="Mumbai" };
            var s3 = new Student { Firstname = "Akash", CGPA = 8, Location = "Mumbai" };
            var s4 = new Student { Firstname="Manish",CGPA=7,Location="Mumbai" };
            var s5 = new Student { Firstname="Dipesh",CGPA=8.5,Location="Thane"};

            IEnumerable<Student> studentdetails = new List<Student> { s1, s2, s3, s4, s5 };

            IEnumerable<Student> studentwithmumbai = studentdetails
                .Where((student) => student.Location.Equals("Mumbai"));

            foreach (Student student in studentwithmumbai) {
                Console.WriteLine("Name:"+student.Firstname+"\tCGPA:"+student.CGPA);
            }

            var studentnameandloc = studentdetails
               .Select((student)=>new { student.Firstname,student.Location});

            foreach (var student in studentnameandloc)
            {
                Console.WriteLine("Name:" + student.Firstname + "\tCGPA:" + student.Location);
            }
        }
    }
}
