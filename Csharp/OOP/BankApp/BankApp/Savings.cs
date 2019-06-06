using System;

namespace BankApp
{
    class Savings:Account
    {
        public Savings(int accountnumber, string name, double balance, string type) : base(accountnumber, name
            , balance, "Saving") { }

        public override void Withdraw(double amount)
        {
            if (_balance < 1000 && (_balance - amount) < 1000)
                throw new LimitExceedException("Minimum limit exceeded!You can not withdraw amount");
            _balance -= amount;
        }
    }
}
