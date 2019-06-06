using System;
using CalculatorLibrary;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            try
            {
                Console.WriteLine("Addition:"+calculator.GetAddition(10, -20));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception catched");
                Console.WriteLine("Message:"+e.Message);
            }
        }
    }
}
