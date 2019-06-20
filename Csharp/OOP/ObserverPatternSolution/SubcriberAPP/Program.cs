using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPublisherLib;

namespace SubcriberAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(101,"ABC",123456789,"abc@",5000);
            account.Subcribe(new EmailNotification());
            account.Subcribe(new SmsNotifiction());

            account.Deposite(1000);

            account.UnSubcribe(new EmailNotification());
            account.Withdraw(500);

        }
    }
}
