using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankingAppLib.Repositry;
using BankingAppLib.Model;

namespace BankingApp2
{
    public partial class PassbookForm : Form
    {
        private PassbookRepositry _passbook;
        private List<BankTransaction> _transactions;
        private string _currentuser;
        public PassbookForm(string name)
        {
            _passbook = new PassbookRepositry();
            _transactions = new List<BankTransaction>();
            _currentuser = name;
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Amount";
            dataGridView1.Columns[2].Name = "Type";
            dataGridView1.Columns[3].Name = "Date";

            foreach (BankTransaction transaction in _transactions)
            {
                string[] row = {transaction.Name,transaction.Amount.ToString(),
                                 transaction.Type,transaction.Date};
                dataGridView1.Rows.Add(row);
            }
        }

        private void PassbookForm_Load(object sender, EventArgs e)
        {
            _transactions = _passbook.GetCustomerData(_currentuser);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
    }
}
