using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle small = new Rectangle();
            Rectangle big = new Rectangle();

            small.SetHeight(-5);
            small.SetWidth(10);

            big.SetHeight(20);
            big.SetWidth(155);

            Console.WriteLine("For Rectangle 1:");
            Console.WriteLine("Height:"+small.GetHeight()+"\nWidth:"+small.GetWidth());
            Console.WriteLine("Area:"+small.AreaCalulatation());

            Console.WriteLine("For Rectangle 2:");
            Console.WriteLine("Height:" + big.GetHeight() + "\nWidth:" + big.GetWidth());
            Console.WriteLine("Area:" + big.AreaCalulatation());
        }
    }
}
