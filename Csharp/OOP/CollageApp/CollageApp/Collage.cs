using System;
using CollageApp.Entity;
using System.Collections.Generic;

namespace CollageApp
{
    class Collage
    {
        private List<Student> _students;
        private List<Professor> _professors;
        private readonly string _name, _address;
        private readonly double _phonenumber;

        public Collage(string name,string address,double phonenumber) {
            _name = name;
            _address = address;
            _phonenumber = phonenumber;
            _students = new List<Student>();
            _professors = new List<Professor>();
        }

        public void AddNewStudent(string name,string dateofbirth,Branch branch,string address) {
            _students.Add(new Student(name,dateofbirth,branch,address));
        }

        public void AddNewProfessor(string name,string dateofbirth,string address) {
            _professors.Add(new Professor(name,dateofbirth,address));
        }

        public List<Student> Students {
            get { return _students; }
        }

        public List<Professor> Professors {
            get { return _professors; }
        }

        public string Name {
            get { return _name; }
        }

        public string Address {
            get { return _address; }
        }

        public double PhoneNumber {
            get { return _phonenumber; }
        }

        public override string ToString()
        {
            return "Name:"+Name+"\nAddress:"+Address+"\nPhone Number:"+PhoneNumber;
        }
    }
}
