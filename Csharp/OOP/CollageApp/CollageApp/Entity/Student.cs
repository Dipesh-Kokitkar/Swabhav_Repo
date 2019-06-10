using System;
namespace CollageApp.Entity
{
    class Student:Person
    {
        private Branch _branch;
        private EnumConvert _enumconvert;

        public Student(string name, string dateofbirth,Branch branch, string address) 
            :base(name,dateofbirth,address) {
            _branch = branch;
            _enumconvert = new EnumConvert();
        }

        public string GetBranch {
            get { return _enumconvert.GetString(_branch); }
        }
    }
}
