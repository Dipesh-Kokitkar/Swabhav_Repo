using System;

namespace RectangleNewApp
{
    class Rectangle
    {
        private int _height, _width;
        private const int LOWERBOUND=0,UPPERBOUND=100;

        public int GetHeight() { return this._height; }
        public int GetWidth() { return this._width; }
        public void SetHeight(int height)
        {
            this._height = CheckVal(height);
        }
        public void SetWidth(int width)
        {
            this._width = CheckVal(width);
        }
        public int AreaCalulatation()
        {
            return _height * _width;
        }
        int CheckVal(int val)
        {
            if (val > LOWERBOUND && val <= UPPERBOUND)
            {
                return val;
            }
            else
            {
                return (val < LOWERBOUND) ? 1 : UPPERBOUND;
            }
        }
    }
}
