using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPublisherLib;

namespace SubscriberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(101,"abc",123456789,"abc@",1000);
            account.balancechangeevent += SmsHandler;
            account.balancechangeevent += EmailHandler;
            account.Deposite(1000);
        }

        static void SmsHandler(Account account) {
            Console.WriteLine("Account balance is updated with current balance is "+account.Balance);
            Console.WriteLine("SMS send successfully");
        }

        static void EmailHandler(Account account) {
            Console.WriteLine("Account balance is updated with current balance is " + account.Balance);
            Console.WriteLine("Email send successfully");
        }
    }
}
