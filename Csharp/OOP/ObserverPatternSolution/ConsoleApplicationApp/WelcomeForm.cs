using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ConsoleApplicationApp
{
    class WelcomeForm:Form
    {
        public WelcomeForm() {
            this.Width = 1024;
            this.Height = 768;
            this.BackColor = Color.CadetBlue;
            this.Text = "Dipesh";
            Button button = new Button();
            button.Text = "Click me";
            this.Controls.Add(button);
        }
    }
}
