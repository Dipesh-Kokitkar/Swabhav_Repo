using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPublisherLib;

namespace TimeStampApp
{
    class AccountProxy
    {
        private readonly Account _account;

        public AccountProxy(int accountno,string name,double mobno,string email,double balance) {
            _account = new Account(accountno,name,mobno,email,balance);
        }

        public void Withdraw(double amount) {
            DateTime befortime = DateTime.Now;
            TimeStamp();
            _account.Withdraw(amount);
            Console.WriteLine(amount+"Rs. is withdraw from your account and current balance is "+_account.Balance);
            TimeStamp();
        }

        public void Deposite(double amount) {
            DateTime befortime = DateTime.Now;
            TimeStamp();
            _account.Deposite(amount);
            Console.WriteLine(amount + "Rs. is deposit in your account and current balance is " + _account.Balance);
            TimeStamp();
        }

        void TimeStamp() {
            DateTime time = DateTime.Now;
            Console.WriteLine("Timestamp:"+time.Day+"/"+time.Month+"/"+time.Year+" "+time.TimeOfDay);
        }
    }
}
