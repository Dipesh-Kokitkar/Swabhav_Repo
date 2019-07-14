using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingAppLib.Model
{
    public class BankTransaction
    {
        private string _name,_date,_type;
        double _amount;
        public BankTransaction(string name,double amount,string type,string date) {
            _name = name;
            _amount = amount;
            _type = type;
            _date = date;
        }

        public string Name {
            get { return _name; }
        }
        public double Amount {
            get { return _amount; }
        }

        public string Type {
            get { return _type; }
        }

        public string Date {
            get { return _date; }
        }
    }
}
