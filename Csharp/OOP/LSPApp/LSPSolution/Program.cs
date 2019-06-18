using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(20,80);
            Square square = new Square(20);

            ShouldNotChangeWidthOfRectangle(rectangle);
            ShouldNotChangeWidthOfRectangle(square);
        }

        static void ShouldNotChangeWidthOfRectangle(IShape shape) {
            int beforewidth = shape.Width;
            shape.Height = 100;
            int afterwidth = shape.Width;

            Console.WriteLine("Result:"+beforewidth.Equals(afterwidth));
        }
    }
}
