using System;
using System.Collections.Generic;
using System.Text;

namespace CircleApp
{
    class Program
    {
        static void PrintInfo(Circle c)
        {
            Console.WriteLine("Radius:"+c.Radius+"\nArea:"+c.CalArea());
        }
        static void Main(string[] args)
        {
            Circle small = new Circle();
            Circle big = new Circle();

            small.Radius = 2.2f;
            big.Radius = 10.5f;

            Console.WriteLine("For Circle 1:");
            Console.WriteLine("Radius:" + small.Radius + "\nArea:" + small.CalArea());

            Console.WriteLine("For Circle 2:");
            Console.WriteLine("Radius:" + big.Radius + "\nArea:" + big.CalArea());

            Circle temp = small;
            Console.WriteLine("temp radius:"+temp.Radius);
            Console.WriteLine("SMall radius:"+small.Radius);

            temp.Radius = 1.1f;
            Console.WriteLine("temp radius:" + temp.Radius);
            Console.WriteLine("Small radius:" + small.Radius);

            PrintInfo(small);
            PrintInfo(big);
        }
    }
}
