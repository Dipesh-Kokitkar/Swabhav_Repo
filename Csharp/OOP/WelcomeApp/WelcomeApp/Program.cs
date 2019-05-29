using System;

namespace WelcomeApp
{
    class Program
    {
        private static void PrintInfo(float val) {
            Console.WriteLine("Overload 1");
            Console.WriteLine(val);
        }
        private static void PrintInfo(double val)
        {
            Console.WriteLine("Overload 2");
            Console.WriteLine(val);
        }
        private static void PrintInfo(String val)
        {
            Console.WriteLine("Overload 3");
            Console.WriteLine(val);
        }
        private static void PrintInfo(char val)
        {
            Console.WriteLine("Overload 4");
            Console.WriteLine(val);
        }
        private static void PrintInfo(int val)
        {
            Console.WriteLine("Overload 5");
            Console.WriteLine(val);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OOP");
            Console.WriteLine(12);
            Console.WriteLine('D');
            Console.WriteLine(30.05f);
            Console.WriteLine(20.6);
            Console.WriteLine(true);
            Console.WriteLine();

            //new changes
            Console.WriteLine("new Changes");
            PrintInfo('C');
            PrintInfo(12);
            PrintInfo(11.5);
            PrintInfo(65.4f);
            PrintInfo("welcome");
        }
    }
}
