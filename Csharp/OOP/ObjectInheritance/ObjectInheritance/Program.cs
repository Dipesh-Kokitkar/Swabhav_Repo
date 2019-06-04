using System;
using AccountApp.Business;


namespace ObjectInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1001,"ABC",5000);
            Console.WriteLine("\n"+account1);
            Console.WriteLine("\n"+account1.ToString());
        }
    }
}
