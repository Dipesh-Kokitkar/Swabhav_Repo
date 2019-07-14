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
    public partial class LoginForm : Form
    {
        private LoginRespositry _login;
        private MainForm _main;
        private string _currentuser;
        public LoginForm()
        {
            _login = new LoginRespositry();
            _main = new MainForm();
            InitializeComponent();
            FormClosing += LoginForm_FormClosing;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string pwd = txt_password.Text;
            if (_login.ValidateUser(name, pwd)) {
                MessageBox.Show("Welcome Login Sucessful", "Information", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //_main.SetStatus(name);
                _currentuser = name;
                MessageBox.Show("Message"+ParentForm);
            }
        }

        private void LoginForm_Closing(CancelEventArgs e) {
            MessageBox.Show("show");
        }

        public string GetStatus() {
            return _currentuser;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
