using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator taxcalulator1 = new TaxCalculator(new DBLogger());
            TaxCalculator taxcalulator2 = new TaxCalculator(new FileLogger());

            Console.WriteLine(taxcalulator1.CalculateTax(4000,0));
            Console.WriteLine(taxcalulator2.CalculateTax(4000,0));
        }
    }
}
