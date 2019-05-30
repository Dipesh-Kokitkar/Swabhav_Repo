using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleNewApp
{
    class Rectangle
    {
        private int _height, _width;
        public int GetHeight() { return this._height; }
        public int GetWidth() { return this._width; }
        public void SetHeight(int height) {
            if (height > 0 && height <= 100)
            {
                this._height = height;
            }
            else {
                this._height = (height < 0) ? 1 : 100;
            }
        }
        public void SetWidth(int width) {
            if (width > 0 && width <= 100)
            {
                this._width = width;
            }
            else
            {
                this._width = (width < 0) ? 1 : 100;
            }
        }
        public int AreaCalulatation() {
            return _height * _width;
        }
    }
}
