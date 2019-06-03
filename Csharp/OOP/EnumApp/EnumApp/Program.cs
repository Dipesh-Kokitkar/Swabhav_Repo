using System;
using System.Collections.Generic;
using System.Text;

namespace EnumApp
{
    class Program
    {
        enum Months { Jan,Feb,March,April,May,June,July,Aug,Sept,Oct,Nov,Dec};
        enum Shapes { Circle,Square};

        float CalArea(float val,Shapes s) {
            if (s == 0)
                return (float)Math.PI * val * val;
            else
                return val * val;
        }
        static void Main(string[] args)
        {
            int s =(int)Months.Jan;
            Console.WriteLine("1st Month:"+s);
            Program P1 = new Program();
            Program P2 = new Program();
            Console.WriteLine("Area of "+Shapes.Circle+"is "+P1.CalArea(2.5f,Program.Shapes.Circle));
            Console.WriteLine("Area of " + Shapes.Square+"is "+ P1.CalArea(5.5f, Program.Shapes.Square));
        }
    }
}
