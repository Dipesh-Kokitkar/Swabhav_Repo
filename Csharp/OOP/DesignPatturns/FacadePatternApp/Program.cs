using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeMaker shapemaker = new ShapeMaker();
            shapemaker.DrawSquare();
            shapemaker.DrewRectangle();
        }
    }
}
