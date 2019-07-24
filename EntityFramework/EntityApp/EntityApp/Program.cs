using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityApp.BusinessModel;

namespace EntityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SwabhavEFDBContext db = new SwabhavEFDBContext();
            //InsertOPeration(db);
            //UpdateOPeration(db);
            // DeleteOpertion(db);
            Console.ReadKey();
            IEnumVSIQuary(db);

            

        }

        private static void InsertOPeration(SwabhavEFDBContext db)
        {
            db.Students.Add(new Student { Id = Guid.NewGuid(), Name = "MANISH", CGPA = 8f });
            db.Students.Add(new Student { Id = Guid.NewGuid(), Name = "AKASH", CGPA = 8.5f });
            db.Students.Add(new Student { Id = Guid.NewGuid(), Name = "SANAL", CGPA = 7.5f });

            db.SaveChanges();
            Console.WriteLine("Data Saved!");
        }

        private static void UpdateOPeration(SwabhavEFDBContext db) {
            var student = db.Students.Where((student1) => student1.Name.Equals("SANAL"));
            foreach (Student stud in student) {
                stud.CGPA = 9.5f;
            }
            db.SaveChanges();
            Console.WriteLine("Data updated!");
        }

        private static void DeleteOpertion(SwabhavEFDBContext db) {
            var student = db.Students.Where((student1) => student1.Name.Equals("MANISH"));
            foreach (Student stud in student)
            {
                db.Students.Remove(stud);
            }
            db.SaveChanges();
            Console.WriteLine("Data deleted!");
        }

        static void IEnumVSIQuary(SwabhavEFDBContext db) {
            var students = db.Students.Where((s) => s.Name.Contains("A"));

            var names = students.Take(2).ToList().Select((s) => new { Name=s.Name.Split(' ')[0],s.CGPA});

            foreach (var student in names) {
                Console.WriteLine(student.Name+" "+student.CGPA);
            }
        }
    }
}
