using System;

namespace ReflectionApp
{
    class Rectangle
    {
        private int _length, _breath;
        public int count;
        public Rectangle(int lenght,int breath) {
            _length = lenght;
            _breath = breath;
        }

        public int Lenght {
            get { return _length; }
            set { _length = value; }
        }

        public int Breath {
            get { return _breath; }
            set { _breath = value; }
        }

        public int CalculateArea() {
            return _length * _breath;
        }
    }
}
