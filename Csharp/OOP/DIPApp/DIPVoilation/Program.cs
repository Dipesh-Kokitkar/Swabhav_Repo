using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPVoilation
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator taxcalculator = new TaxCalculator(LogType.FILE);
            Console.WriteLine(taxcalculator.CalculateTax(2000,0));
        }
    }
}
