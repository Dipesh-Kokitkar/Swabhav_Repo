using System;

namespace BankApp
{
    class Savings:Account
    {
        private const int MINIMUMBALANCE= 1000;

        public Savings(int accountnumber, string name, double balance) : base(accountnumber, name
            , balance,"Savings") { }

        public override void Withdraw(double amount)
        {
            if (_balance < MINIMUMBALANCE && (_balance - amount) < MINIMUMBALANCE)
                throw new LimitExceedException("Minimum limit exceeded!You can not withdraw amount");
            _balance -= amount;
        }
    }
}
