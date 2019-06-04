using System;
using AccountApp.Business;

namespace AccountApp
{
    class Program
    {
        static void PrintInfo(Account A) {
            Console.WriteLine("Account Infomation:");
            Console.WriteLine("Account No:"+A.accountno+"\nName:" + A.name+"\nBalace:"+A.Balance+"\n");
        }
        static void Main(string[] args)
        {
            Account account1 = new Account(123, "ABC", 4000);
            Console.WriteLine("Total accounts:" + Account.Count);
            Account account2 = new Account(124, "XYZ");
            Console.WriteLine("Total accounts:" + Account.Count);

            //Casestd(A1, A2);

            Account account3 = new Account(125,"LMN",5000);
            Console.WriteLine("Total accounts:" + Account.Count);
        }

        private static void Casestd(Account A1, Account A2)
        {
            PrintInfo(A1);
            PrintInfo(A2);

            Console.WriteLine("\tAfter Withdraw:");
            A1.Withdraw(500);
            A2.Withdraw(200);

            PrintInfo(A1);
            PrintInfo(A2);

            Console.WriteLine("\tAfter Deposit:");
            A1.Deposit(1000);
            A2.Deposit(2000);

            PrintInfo(A1);
            PrintInfo(A2);
        }
    }
}
