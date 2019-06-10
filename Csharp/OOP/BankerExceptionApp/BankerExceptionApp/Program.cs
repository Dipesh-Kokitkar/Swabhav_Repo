using System;
using AccountApp.Business;

namespace BankerExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1001,"Abc",10000);
            try
            {
                account1.Withdraw(20000);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }   
        }
    }
}
