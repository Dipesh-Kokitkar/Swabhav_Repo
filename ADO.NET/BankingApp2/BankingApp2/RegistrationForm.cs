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
    public partial class RegistrationForm : Form
    {
        private RegistrationRespositry _registration;
        public RegistrationForm()
        {
            _registration = new RegistrationRespositry();
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string name, password, cpassword;
            double amount;

            name = txt_name.Text;
            password = txt_password.Text;
            cpassword = txt_cpassword.Text;
            amount = Convert.ToDouble(txt_amount.Text);

            if (password.Equals(cpassword))
            {
                bool result = _registration.RegistorNewAccount(name, password, amount);
                if (result)
                {
                    MessageBox.Show("Registration Sucessful! Plz login again", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    LoginForm login = new LoginForm();
                    login.ShowDialog();
                    Close();

                }
                else
                {
                    MessageBox.Show("Registeration", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Password and confirm password must be same", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
