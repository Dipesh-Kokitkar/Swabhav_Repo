using System;
using CollageApp.Entity;
using System.Collections.Generic;

namespace CollageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Collage collage = new Collage("VIT", "Mumbai", 123456789);

            collage.AddNewProfessor("ABC", "02-Nov-1966", "Mumbai");
            collage.AddNewStudent("XYZ", "10-Oct-1997", Branch.CMPN, "Thane");

            Console.WriteLine(collage.ToString());
            ShowProfessorInformation(collage);
            ShowStudentInformatio(collage);
        }
        static void ShowStudentInformatio(Collage collage)
        {
            IEnumerable<Student> studentlist = collage.Students;

            foreach (Student student in studentlist)
            {
                Console.WriteLine("\n\tStudent Information");
                Console.WriteLine("Name:" + student.Name + "\nDate Of Birth:" + student.DateOfBirth
                    + "\nBranch:" + student.GetBranch + "\nAge:" + student.GetAge() + "\nAddress" + student.Address);
            }
        }

        static void ShowProfessorInformation(Collage collage)
        {
            IEnumerable<Professor> professorlist = collage.Professors;

            foreach (Professor professor in professorlist)
            {
                Console.WriteLine("\n\tProfessor Information");
                Console.WriteLine("Name:" + professor.Name + "\nDate Of Birth:" + professor.DateOfBirth +
                    "\nAge:" + professor.GetAge() + "\nSalary:" + professor.CalculateSalary());
            }
        }
    }
}
