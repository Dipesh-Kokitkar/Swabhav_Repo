using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SynchronousPatternApp
{
    class SynForm:Form
    {
        public SynForm() {
            Height = 768;
            Width = 1024;
            Text = "Synchronation";

            Button hello = new Button();
            hello.Text = "Hello";
            hello.Location = new Point(20,30);
            hello.Click+=PrintHello;
            Controls.Add(hello);

            Button print = new Button();
            print.Text = "Print";
            print.Location = new Point(20, 50);
            print.Click += PrintTime;


            Controls.Add(print);
        }

         void PrintHello(object sender,EventArgs e) {
            Console.WriteLine("hello");
        }

        public void PrintTime(object sender,EventArgs e) {
            while (true) {
                DateTime time = DateTime.Now;
                Console.WriteLine("Time:" + time.Hour + ":"+time.Minute+":"+time.Second);
            }
        }
    }
}
