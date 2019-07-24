using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneToManyEFApp.BusinessModel;

namespace OneToManyEFApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press key");
            Console.ReadKey();
            DataBaseContext db = new DataBaseContext();

            Department CMPN = new Department();
            CMPN.Deptno = 10;
            CMPN.Dname = "CMPN";
            CMPN.Students.Add(new Student { Rollno = 1, Name = "DSK", CGPA = 8.2 });

            

            Department IT = new Department();
            IT.Deptno = 20;
            IT.Dname = "IT";
            IT.Students.Add(new Student { Rollno = 2, Name = "ABC", CGPA = 9});

            db.Departemnts.Add(CMPN);
            db.Departemnts.Add(IT);
            db.SaveChanges();
            Console.WriteLine("Department and student table created");

        }
    }
}
