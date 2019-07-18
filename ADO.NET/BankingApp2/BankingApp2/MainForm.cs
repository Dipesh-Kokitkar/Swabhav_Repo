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
        private static string _currentuser;
        LoginForm _login;

        public MainForm()
        {
            InitializeComponent();
            doOperationToolStripMenuItem.Enabled = false;
            passbookToolStripMenuItem.Enabled = false;
            btn_logout.Enabled = false;
        }

        public static void SetName(string name,MainForm main) {
            _currentuser = name;
            MessageBox.Show("Name:"+name);
            main.Check();
        }
        

        private void doOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _login = new LoginForm(this);
            _login.MdiParent = this;
            _login.Show();
            lab_inital.Hide();
            
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm register = new RegistrationForm();
            register.MdiParent = this;
            register.Show();
            lab_inital.Hide();
        }
        private void Check() {
            if (_currentuser != null)
            {
                doOperationToolStripMenuItem.Enabled = true;
                passbookToolStripMenuItem.Enabled = true;
                label3.Text = _currentuser;
                registerToolStripMenuItem.Enabled = false;
                btn_logout.Enabled = true;

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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doOperationToolStripMenuItem.Enabled = false;
            passbookToolStripMenuItem.Enabled = false;
            registerToolStripMenuItem.Enabled = true;
            lab_inital.Enabled = true;
            lab_inital.Show();
            label3.Text = "user";
        }
    }
}
