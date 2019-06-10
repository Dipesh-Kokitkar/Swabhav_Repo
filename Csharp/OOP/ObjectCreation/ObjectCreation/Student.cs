using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectCreation
{
    class Student
    {
        private string _name;
        private int _rollnumber;

        public Student() {
            _name = "ABC";
            _rollnumber = 110;
        }

        public int RollNumber
        {
            get
            {
                return _rollnumber;
            }

        }

        public string Name
        {
            get { return _name; }
        }
    }
}
