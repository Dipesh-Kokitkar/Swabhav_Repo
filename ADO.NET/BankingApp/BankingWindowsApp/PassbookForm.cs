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
using System.IO;

namespace BankingWindowsApp
{
    public partial class PassbookForm : Form
    {
        private PassbookRepositry _passbook;
        private List<BankTransaction> _transactions;
        private string _currentuser;
        public PassbookForm(string name)
        {
            InitializeComponent();

            _passbook = new PassbookRepositry();
            _transactions = new List<BankTransaction>();
            _currentuser = name;
            lab_currentuser.Text = name;
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void btn_button_Click(object sender, EventArgs e)
        {
            StringBuilder lines = new StringBuilder();
            foreach (BankTransaction transaction in _transactions)
            {
                lines.AppendLine(transaction.Name + "," + transaction.Amount.ToString() + ","
                    + transaction.Type + "," + transaction.Date);
            }
            File.AppendAllText("passbook.csv", lines.ToString());
            MessageBox.Show("Saved!");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm main = new MainForm(_currentuser);
            main.ShowDialog();
            Close();
        }
    }
}
