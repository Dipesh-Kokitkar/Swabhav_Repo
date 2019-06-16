using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            FixDeposit account = new FixDeposit("ABC",10000,2,
                new Festival("Holi",0.08));

            FixDeposit account2 = new FixDeposit("ABC", 10000, 2,
                new Festival("Normal", 0.07));

            Console.WriteLine("Interest1:"+account.CalculateSimpleInterest());
            Console.WriteLine("Interest2:" + account2.CalculateSimpleInterest());
        }
    }
}
