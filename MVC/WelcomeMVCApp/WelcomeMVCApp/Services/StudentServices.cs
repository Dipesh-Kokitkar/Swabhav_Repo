using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMVCApp.BusinessModel;
using WelcomeMVCApp.Repositry;

namespace WelcomeMVCApp.Services
{
    public class StudentServices
    {
        //private static List<Student> _students;
        private int _count;
        private StudentRepositry _studentrepositry;



        public StudentServices()
        {
            _studentrepositry = new StudentRepositry();
            //_students = new List<Student>();

            //_students.Add(new Student { Rollno = 1, Name = "Sanal", CGPA = 9.5, Birthdate = Convert.ToDateTime("1997/05/10"), Location = "Raigad" });
            //_students.Add(new Student { Rollno = 2, Name = "Dhurv", CGPA = 9, Birthdate = Convert.ToDateTime("1998/02/10"), Location = "Mumbai" });
            //_students.Add(new Student { Rollno = 3, Name = "Akash", CGPA = 8, Birthdate = Convert.ToDateTime("1997/12/05"), Location = "Mumbai" });

        }
        public List<Student> GetStudents()
        {

            //return _students;
            return _studentrepositry.GetStudents();
        }

        public Student GetStudentByRollno(int rollno)
        {
            /*foreach (Student student in _students)
            {
                if (student.Rollno == rollno)
                {
                    return student;
                }
            }
            return null;*/
            return _studentrepositry.GetStudentByRollno(rollno);
        }

        public void AddNewStudent(Student student)
        {
            // _students.Add(student);
            _studentrepositry.AddNewStudent(student);
        }

        public void DeleteStudent(Student student) {
            // _students.Remove(student);
            _studentrepositry.DeleteStudentData(student);
        }

        public void EditStudent(Student updatedstudent) {
            _studentrepositry.UpdateStudentData(updatedstudent);
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
            return _studentrepositry.GetCount();
        }
    }
}