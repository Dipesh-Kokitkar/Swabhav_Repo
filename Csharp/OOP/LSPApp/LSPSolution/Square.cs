using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSPSolution
{
    class Square:IShape
    {
        private int _sides;

        public Square(int sides) {
            _sides = sides;
        }

        public int Height
        {
            get
            {
                return _sides;
            }

            set
            {
                _sides = value;
            }
        }

        public int Width
        {
            get
            {
                return _sides;
            }

            set
            {
                _sides = value;
            }
        }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }
}
