using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using BankingAppLib.Model;
using BankingAppLib.Repositry;

namespace BankingApp2
{
    class DownloadPassbook
    {
        private PassbookRepositry _passbook;
        private List<BankTransaction> _transactions;
        private string _currentuser;

        public DownloadPassbook(string name) {
            _passbook = new PassbookRepositry();
            _transactions = new List<BankTransaction>();
            _currentuser = name;
        }

        public void Download() {
            _transactions = _passbook.GetCustomerData(_currentuser);
            StringBuilder lines = new StringBuilder();
            foreach (BankTransaction transaction in _transactions)
            {
                lines.AppendLine(transaction.Name + "," + transaction.Amount.ToString() + ","
                    + transaction.Type + "," + transaction.Date);
            }
            File.AppendAllText("passbook.csv", lines.ToString());
        }
    }
}
