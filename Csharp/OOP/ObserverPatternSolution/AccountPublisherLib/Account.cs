using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPublisherLib
{
    public class Account
    {
        private readonly int _accountnumber;
        private readonly string _name;
        private readonly double _mobilenumber;
        private readonly string _email;
        private double _balance;
        private List<IBalanceChangedNotifer> _subcriberlist;

        public Account(int accountno,string name,double mobno,string email,double balance) {
            _accountnumber = accountno;
            _name = name;
            _mobilenumber = mobno;
            _email = email;
            _balance = balance;
            _subcriberlist = new List<IBalanceChangedNotifer>();
        }

        public int AccountNumber {
            get { return _accountnumber; }
        }

        public string Name {
            get { return _name; }
        }

        public string Email {
            get { return _email; }
        }

        public double MobileNumber {
            get { return _mobilenumber; }
        }

        public double Balance {
            get { return _balance; }
        }

        public void Withdraw(double amount) {
            if ((Balance < 500) && (Balance - amount) < 500)
                return;
            _balance -= amount;
            Notify();
        }

        public void Deposite(double amount) {
            _balance += amount;
            Notify();
        }

        public void Subcribe(IBalanceChangedNotifer subcriber) {
            _subcriberlist.Add(subcriber);
        }

        public void UnSubcribe(IBalanceChangedNotifer subcriber) {
            _subcriberlist.Remove(subcriber);
        }

        public void Notify() {
            foreach (IBalanceChangedNotifer subcriber in _subcriberlist)
                subcriber.Update(this);
        }
    }
}
