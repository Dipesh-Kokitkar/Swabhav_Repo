using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankingAppLib.Repositry;

namespace BankingWindowsApp
{
    public partial class MainForm : Form
    {
        private string _currentuser;
        private Main _main;

        public MainForm(string name)
        {
            InitializeComponent();
            _main = new Main(name);
            label6.Text = name;
            label6.Font = new Font("Microsoft Sans Serif", 12);
            _currentuser = name;
            label3.Text = _currentuser;
            label5.Text = _main.GetCurrentUser();
            label5.Font = new Font("Microsoft Sans Serif", 12);
            label3.Font= new Font("Microsoft Sans Serif", 12);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_passbook_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassbookForm passbook = new PassbookForm(_currentuser);
            passbook.ShowDialog();
            Close();
        }

        private void btn_operation_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperationsForm operation = new OperationsForm(_currentuser);
            operation.ShowDialog();
            Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            Close();
        }
    }
}
