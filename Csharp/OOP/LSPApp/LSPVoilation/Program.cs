using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSPVoilation
{
    class Program
    {
        static void Main(string[] args)
        {
            ShouldNotChangeWidthAndChangeHeight(new Rectangle(20, 80));
            ShouldNotChangeWidthAndChangeHeight(new Square(20));
        }

        static void ShouldNotChangeWidthAndChangeHeight(Rectangle reactange) {
            int beforewidth = reactange.Width;
            reactange.Height = 100;
            int afterwidth = reactange.Width;

            Console.WriteLine("Result:"+beforewidth.Equals(afterwidth));
        }
    }
}
