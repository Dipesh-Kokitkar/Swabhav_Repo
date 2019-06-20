using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeStampApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountProxy account = new AccountProxy(101,"ABC",123456789,"abc@",5000);

            account.Withdraw(1000);

            Console.WriteLine();
            account.Deposite(2000);
        }
    }
}
