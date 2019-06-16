using System;
using System.Collections.Generic;
using System.Linq;
using CalciLib;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            try {
                Console.WriteLine("Enter Number:");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result:" + calculator.CalculateEvenCube(number));
            }
            catch (Exception e) {
                Console.WriteLine("Message:"+e.Message);
            }

        }
    }
}
