using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePatternApp
{
    class ShapeMaker
    {
        private Rectangle _reactangle;
        private Square _square;

        public ShapeMaker()
        {
            _reactangle = new Rectangle();
            _square = new Square();
        }

        public void DrewRectangle()
        {
            _reactangle.draw();
        }

        public void DrawSquare()
        {
            _square.draw();
        }
    }
}
