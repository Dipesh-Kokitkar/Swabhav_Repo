using System;
using BankerExceptionApp;

namespace AccountApp.Business
{
    class Account
    {
        private readonly int _accountno;
        private readonly string _name;
        private double _balance;
        private static int _count;

        static Account(){
            _count = 0;
            Console.WriteLine("inside static block");
        }
        public Account(int accno,string name,double balance) {
            _accountno = accno;
            _name = name;
            _balance = balance;
            _count += 1;
            Console.WriteLine("Inside the constrctor");
        }

        public Account(int accno, string name):this(accno,name,500) { }

        public void Deposit(double amt) {
            _balance += amt;
        }

        public void Withdraw(double amount) {
            if (_balance < amount)
                throw new InsufficientFundException(this,amount);
            if (!(_balance <= 500)&& !(_balance-amount<=500)) {
                _balance -= amount;
            }
        }

        public int accountno {
            get { return _accountno; }
        }

        public string name {
            get { return _name; }
        }

        public double Balance {
            get { return _balance; }
        }

        public static  int Count {
            get{ return _count; }
        }
    }
}
