using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSPSolution
{
    class Rectangle:IShape
    {
        private int _width;
        private int _height;

        public Rectangle(int width, int height) {
            _width = width;
            _height = height;
        }


        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public int CalculateArea()
        {
           return Width*Height;
        }
    }
}
