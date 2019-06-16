using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPSolution2
{
    class Program
    {
        static void Main(string[] args)
        {
            FixDeposit account1 = new FixDeposit("Abc", 10000, 2, new HoliFestival());
            FixDeposit account2 = new FixDeposit("XYZ", 10000, 2, new NoFestival());

            DisplayInformation(account1);
            DisplayInformation(account2);
        }

        static void DisplayInformation(FixDeposit account) {
            Console.WriteLine("\tAccount Information");
            Console.WriteLine("\nName:"+account.Name+"\nPrinciple:"+account.Principal+
                "\nYear:"+account.Year+"\nInterest:"+account.CalculateSimpleInterest());
            
        }
    }
}
