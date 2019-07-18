using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMVCApp.BusinessModel;

namespace WelcomeMVCApp.Services
{
    public class StudentServices
    {
        private static List<Student> _students;
        private int _count;



        static StudentServices()
        {
            _students = new List<Student>();

            _students.Add(new Student { Rollno = 1, Name = "Sanal", CGPA = 9.5, Birthdate = Convert.ToDateTime("1997/05/10"), Location = "Raigad" });
            //_students.Add(new Student { Rollno = 2, Name = "Dhurv", CGPA = 9, Birthdate = Convert.ToDateTime("1998/02/10"), Location = "Mumbai" });
            //_students.Add(new Student { Rollno = 3, Name = "Akash", CGPA = 8, Birthdate = Convert.ToDateTime("1997/12/05"), Location = "Mumbai" });

        }
        public List<Student> GetStudents()
        {

            return _students;
        }

        public Student GetStudentByRollno(int rollno)
        {
            foreach (Student student in _students)
            {
                if (student.Rollno == rollno)
                {
                    return student;
                }
            }
            return null;
        }

        public void AddNewStudent(Student student)
        {
            _students.Add(student);
        }

        public void DeleteStudent(Student student) {
            _students.Remove(student);
        }

        public void EditStudent(Student updatedstudent) {
            foreach (Student student in _students) {
                if (updatedstudent.Rollno == student.Rollno) {
                    student.Name = updatedstudent.Name;
                    student.Birthdate = updatedstudent.Birthdate;
                    student.CGPA = updatedstudent.CGPA;
                    student.Location = updatedstudent.Location;
                }
            }
        }

        public Student ConvertVMToStudent(string rollno, string name, string DOB, string cgpa, string location)
        {
            Student student = new BusinessModel.Student
            {
                Rollno = Convert.ToInt32(rollno),
                Name = name,
                Birthdate = Convert.ToDateTime(DOB),
                CGPA = Convert.ToDouble(cgpa),
                Location = location
            };
            return student;
        }
        public int GetCount()
        {
            _count = _students.Count;
            return _count;
        }
    }
}