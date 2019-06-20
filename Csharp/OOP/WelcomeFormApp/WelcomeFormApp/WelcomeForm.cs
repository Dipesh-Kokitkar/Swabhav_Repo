using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WelcomeFormApp
{
    class WelcomeForm:Form
    {
        public WelcomeForm() {
            Height = 1024;
            Width = 786;
            Text = "Dipesh";
            BackColor = Color.CadetBlue;

            Button button = new Button();
            button.Text = "Click Me";
            this.Controls.Add(button);
            button.Click += HelloHandler;
            button.Click += GoodbyeHandler;
            
        }

         void HelloHandler(object sender,EventArgs events) {
            Console.WriteLine("Hello");
        }

        void GoodbyeHandler(object sender, EventArgs events)
        {
            Console.WriteLine("Goodbye");
        }
    }
}
