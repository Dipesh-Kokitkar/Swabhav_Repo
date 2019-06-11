using System;
using AccountApp.Business;

namespace BankerExceptionApp
{
    class InsufficientFundException : Exception
    {
        private readonly Account _account;
        private readonly double _amount;

        public InsufficientFundException(Account account, double amount)
        {
            _account = account;
            _amount = amount;
        }

        public override string Message
        {
            get
            {
                return "\nAccount No:" + _account.accountno + "\nName:" + _account.name +
                    "\nYou trying to withdraw " + _amount + " and your current balance is " + _account.Balance
                    + " Sorry Insuffient Balance ";
            }
        }
    }
}
