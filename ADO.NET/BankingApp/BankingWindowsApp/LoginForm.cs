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
    public partial class LoginForm : Form
    {
        private LoginRespositry _login;
        public LoginForm()
        {
            _login = new LoginRespositry();
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string password = txt_password.Text;

            if (!(name == string.Empty) && !(password == string.Empty))
            {
                bool result = _login.ValidateUser(name, password);
                if (result)
                {
                    MessageBox.Show("Login Sucessful", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainForm main = new MainForm(name);
                    main.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Fail!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else {
                MessageBox.Show("Plz enter password and username", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm register = new RegistrationForm();
            this.Hide();
            register.ShowDialog();
            Close();
        }
    }
}
