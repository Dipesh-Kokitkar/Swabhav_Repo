using System;

namespace BankApp
{
    class Current:Account
    {
        public Current(int accountnumber, string name, double balace, string type) : base(accountnumber, name
            , balace, "Current") { }

        public override void Withdraw(double amount)
        {
            _balance -= amount;
        }
    }
}
