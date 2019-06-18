using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSPVoilation
{
    class Square:Rectangle
    {
        private int _side;

        public Square(int side):base(side,side) { }

        public override int Width
        {
            get
            {
                return base.Width;
            }

            set
            {
                base.Height=base.Width = value;
            }
        }

        public override int Height
        {
            get
            {
                return base.Height;
            }

            set
            {
                base.Width=base.Height = value;
            }
        }
    }
}
