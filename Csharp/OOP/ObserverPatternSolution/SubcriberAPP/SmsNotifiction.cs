using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPublisherLib;

namespace SubcriberAPP
{
    class SmsNotifiction : IBalanceChangedNotifer
    {

        public void Update(Account account)
        {
            Console.WriteLine(" Hello" + account.Name + "! your balance is updated to " + account.Balance);
            Console.WriteLine("SMS is sucessfully send");
        }

    }
}
