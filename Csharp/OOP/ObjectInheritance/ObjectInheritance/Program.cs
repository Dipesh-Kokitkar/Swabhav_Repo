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
            Account account2 = new Account(1001, "ABC", 5000);

            Console.WriteLine(account1==account1);
            Console.WriteLine(account1==account2);
            Console.WriteLine(account1.Equals(account1));
            Console.WriteLine(account1.Equals(account2));
            Console.WriteLine(account1.GetHashCode());
            Console.WriteLine(account2.GetHashCode());
        }
    }
}
