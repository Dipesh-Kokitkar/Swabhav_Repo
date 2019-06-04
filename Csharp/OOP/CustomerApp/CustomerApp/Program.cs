using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("ABC","XYZ");
            Customer customer2 = new Customer("ABC", "XYZ");
            Customer customer3 = new Customer("ABC", "XYZ");

            Console.WriteLine("ID for customer1:" + customer1.Id);
            Console.WriteLine("ID for customer2:" + customer2.Id);
            Console.WriteLine("ID for customer3:" + customer3.Id);
        }
    }
}
