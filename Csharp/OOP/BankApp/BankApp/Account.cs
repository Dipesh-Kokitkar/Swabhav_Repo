using System;

namespace BankApp
{
    abstract class Account
    {
        private int _accountnumber;
        private string _name, _type;
        protected double _balance;

        public Account(int accountnumber, string name, double balance, string type)
        {
            _accountnumber = accountnumber;
            _name = name;
            _balance = balance;
            _type = type;
        }

        public int AccounNumber
        {
            get { return _accountnumber; }
        }

        public string Name
        {
            get { return _name; }
        }

        public double Balance
        {
            get { return _balance; }
        }

        public string Type
        {
            get { return _type; }
        }

        public void Deposite(double amount)
        {
            _balance += amount;
        }

        public abstract void Withdraw(double amount);
    }
}
