using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSPVoilation
{
    class Rectangle
    {
        private int _width;
        private int _height;

        public Rectangle(int width,int height) {
            _width = width;
            _height = height;
        }

        public virtual int Width {
            get { return _width; }
            set {_width = value; }
        }

        public virtual int Height {
            get { return _height; }
            set { _height = value; }
        }

        public int CalculateArea() {
            return Width * Height;
        }
    }
}
