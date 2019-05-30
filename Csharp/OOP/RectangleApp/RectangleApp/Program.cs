using System;
using RectangleApp;
namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] R = new Rectangle[3];
            int sum = 0;
            for (int i = 0; i < 3; i++) {
                R[i] = new Rectangle();
                Console.WriteLine("Enter width and height for Reactangle {0}:",i);
                R[i].width = Convert.ToInt32(Console.ReadLine());
                R[i].height = Convert.ToInt32(Console.ReadLine());
                sum += R[i].CalculateArea();
            }
            Console.WriteLine("Total sum of Reactangles are {0}",sum);
            /*Console.WriteLine("For small==>");
            Console.WriteLine("Height:" + small.height + "\nWidth:" + small.width);
            Console.WriteLine("Area:" + small.CalculateArea());

            Console.WriteLine("For Big==>");
            Console.WriteLine("Height:" + big.height + "\nWidth:" + big.width);
            Console.WriteLine("Area:" + big.CalculateArea());*/
           
        }
    }
}
