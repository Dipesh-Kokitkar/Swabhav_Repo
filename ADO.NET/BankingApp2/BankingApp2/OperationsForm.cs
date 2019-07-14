using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankingAppLib.Repositry;

namespace BankingApp2
{
    public partial class OperationsForm : Form
    {
        private string _currentuser;
        private AccountTransactionRespositry _account;
        public OperationsForm(string name)
        {
            InitializeComponent();
            _currentuser = name;
            _account = new AccountTransactionRespositry();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool validate()
        {
            double amount = Convert.ToDouble(txt_amount.Text);
            if (amount == 0)
            {
                MessageBox.Show("Plz enter amount");
                return false;
            }
            if (!radio_deposite.Checked && !radio_withdraw.Checked)
            {
                MessageBox.Show("Plz select mode of Operation");
                return false;
            }
            return true;
        }

        private void Reset()
        {
            txt_amount.Text = "";
            radio_deposite.Checked = false;
            radio_withdraw.Checked = false;
        }

        private void btn_perform_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                double amount = Convert.ToDouble(txt_amount.Text);
                if (radio_deposite.Checked)
                {
                    if (_account.Deposite(_currentuser, amount))
                    {
                        MessageBox.Show("Amount Deposited");
                        Reset();
                    }
                    else { MessageBox.Show("Fail!"); Reset(); }
                }
                if (radio_withdraw.Checked)
                {
                    if (_account.Withdraw(_currentuser, amount))
                    {
                        MessageBox.Show("Amount Withdraw");
                        Reset();
                    }
                    else { MessageBox.Show("Fail!"); Reset(); }
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
