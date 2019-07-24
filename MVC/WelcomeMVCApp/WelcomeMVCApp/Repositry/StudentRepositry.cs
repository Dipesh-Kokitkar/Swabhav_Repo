using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMVCApp.BusinessModel;

namespace WelcomeMVCApp.Repositry
{
    public class StudentRepositry
    {
        private AurionProEFDBContext _context;

        public StudentRepositry() {
            _context = new AurionProEFDBContext();
        }

        public List<Student> GetStudents() {
            return _context.Students.ToList();
        }

        public Student GetStudentByRollno(int rollno) {
           var IqueryStudent= _context.Students.Where((student)=>student.Rollno==rollno);
            foreach (Student student in IqueryStudent) {
                return student;
            }
            return null;
        }

        public void AddNewStudent(Student student) {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void UpdateStudentData(Student updatedstudent) {
           var Iquerystudents=_context.Students.Where((s) => s.Rollno == updatedstudent.Rollno);
            foreach (var student in Iquerystudents) {
                student.Name = updatedstudent.Name;
                student.Birthdate = updatedstudent.Birthdate;
                student.CGPA = updatedstudent.CGPA;
                student.Location = updatedstudent.Location;
            }
            _context.SaveChanges();
        }

        public void DeleteStudentData(Student student) {
                _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public int GetCount() {
            return _context.Students.Count();
        }
    }
}