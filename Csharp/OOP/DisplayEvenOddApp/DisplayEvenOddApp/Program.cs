using System;
using System.Collections;

namespace DisplayEvenOddApp
{
    class Program
    {
        static void PrintNumbers(ArrayList numberList) {
            foreach(int number in numberList)
                Console.Write(" "+number);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            EvenOrOdd number = new EvenOrOdd();

            Console.WriteLine("\nEven numbers between 1 to 100:");
            Console.WriteLine();
            PrintNumbers(number.GetEvenNumbers());

            Console.WriteLine("\nOdd numbers between 1 to 100:");
            Console.WriteLine();
            PrintNumbers(number.GetOddNumbers());

        }
    }
}
