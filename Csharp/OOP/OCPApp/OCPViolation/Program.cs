using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit account = new FixedDeposit("Abc",10000,2,FestivalType.HOLI);

            Console.WriteLine("\nName:"+account.Name+"\nPrincipal:"+account.Principal+
                "\nYear:"+account.Year+"\nInterset:"+account.CalculateSimpleInterest());
        }
    }
}
