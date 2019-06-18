using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPatturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(new AddOperation());
            Console.WriteLine("Add:"+calculator.ExecuteOperation(12,20));

            Calculator calculator1 = new Calculator(new SubstarctOperation());
            Console.WriteLine("Add:" + calculator.ExecuteOperation(120, 20));

            Calculator calculator2 = new Calculator(new Multipliction());
            Console.WriteLine("Add:" + calculator.ExecuteOperation(12, 20));
        }
    }
}
