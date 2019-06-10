using System;

namespace ExceptionApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c=0;
            try
            {
                int a = Convert.ToInt32(args[0]);
                int b = Convert.ToInt32(args[1]);
                int d = Convert.ToInt32(args[2]);
                c = a / b;
            }
            catch (FormatException)
            {
                Console.WriteLine("Parametars must be number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denomenator should not be zero");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The should be less");
            }
            Console.WriteLine("Result is "+c);
            Console.WriteLine("End of main");
           // Main(args);
        }
    }
}
