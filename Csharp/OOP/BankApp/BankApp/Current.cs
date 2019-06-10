using System;

namespace BankApp
{
    class Current:Account
    {
        public Current(int accountnumber, string name, double balance) : base(accountnumber, name
            , balance, "Current") { }

        public override void Withdraw(double amount)
        {
            //if(-5000 < )
            _balance -= amount;
        }
    }
}
