using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WelcomeFormApp
{
    class CommanForm : Form
    {
        public CommanForm() {
            Height = 1024;
            Width = 786;
            Text = "Dipesh";
            BackColor = Color.CadetBlue;

            Button blue = new Button();
            blue.Text = "Blue";
            blue.Location = new Point(10,10);
            blue.Click += CommanHandler;

            Button red = new Button();
            red.Text = "Red";
            red.Location = new Point(100,10);
            red.Click += CommanHandler;
            
            Controls.Add(blue);
            Controls.Add(red);
        }

        void CommanHandler(object sender,EventArgs events)
        {
            Button button = (Button)sender;
            if (button.Text.Equals("Blue"))
                BackColor = Color.Blue;
            else
                BackColor = Color.Red;
        }
    }
}
