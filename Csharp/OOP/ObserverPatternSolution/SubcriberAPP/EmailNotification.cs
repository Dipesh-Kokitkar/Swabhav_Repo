using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPublisherLib;

namespace SubcriberAPP
{
    class EmailNotification : IBalanceChangedNotifer
    {
        public void Update(Account account)
        {
            Console.WriteLine(" Hello"+account.Name+"! your balance is updated to "+account.Balance);
            Console.WriteLine("Email is sucessfully send");
        }
    }
}
