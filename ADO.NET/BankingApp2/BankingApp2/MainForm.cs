using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankingApp2
{
    public partial class MainForm : Form
    {
        private string _currentuser;
        LoginForm _login;
        public MainForm()
        {
            InitializeComponent();
            doOperationToolStripMenuItem.Enabled = false;
            passbookToolStripMenuItem.Enabled = false;
            //Check();
        }

        private void doOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void SetStatus(string name)
        {
            _currentuser = name;
            label3.Text = name;
            if (_currentuser != null)
            {
                doOperationToolStripMenuItem.Enabled = true;
                passbookToolStripMenuItem.Enabled = true;
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _login = new LoginForm();
            _login.MdiParent = this;
            _login.Show();
            MessageBox.Show("abc");
            //Check();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm register = new RegistrationForm();
            register.MdiParent = this;
            register.Show();
        }
        private void Check() {
            _currentuser = _login.GetStatus();
            if (_currentuser != null)
            {
                doOperationToolStripMenuItem.Enabled = true;
                passbookToolStripMenuItem.Enabled = true;
            }
        }

        private void doTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationsForm operation = new OperationsForm(_currentuser);
            operation.MdiParent = this;
            operation.Show();
        }

        private void showTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassbookForm passbook = new PassbookForm(_currentuser);
            passbook.MdiParent = this;
            passbook.Show();
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DownloadPassbook downloadpassbook = new DownloadPassbook(_currentuser);
            downloadpassbook.Download();
            MessageBox.Show("Saved");
        }
    }
}
