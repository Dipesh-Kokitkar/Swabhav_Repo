using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionApp2
{
    class Student
    {
        private readonly string _name;
        private readonly int _rollnumber;
        private int _standard;

        public Student(int rollnumber,int standard,string name) {
            _rollnumber = rollnumber;
            _standard = standard;
            _name = name;
        }

        public int RollNumber {
            get { return _rollnumber; }
        }

        public int Standard {
            get { return _standard; }
        }

    }
}
