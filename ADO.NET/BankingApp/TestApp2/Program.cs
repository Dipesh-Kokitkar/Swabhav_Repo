using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingAppLib.Repositry;

namespace TestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Main main = new Main("dsk");
            Console.WriteLine(main.GetCurrentUser());
        }
    }
}
