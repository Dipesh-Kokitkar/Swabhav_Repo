using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace AsynPatternApp
{
    class AsynForm : Form
    {
        public AsynForm()
        {
            Height = 768;
            Width = 1024;
            Text = "AsynApp";

            Button hello = new Button();
            hello.Text = "Hello";
            hello.Location = new Point(20, 30);
            hello.Click += PrintHello;
            Controls.Add(hello);

            Button print = new Button();
            print.Text = "Print";
            print.Location = new Point(20, 50);
            print.Click += NewThread;


            Controls.Add(print);

        }

        void PrintHello(object sender, EventArgs e)
        {
            Console.WriteLine("Hello");
        }

        public void NewThread(object sender, EventArgs e) {
            Thread t = new Thread(PrintTime);
            Thread t=new 
            t.Start();
        }

        public void PrintTime()
        {
            while (true)
            {
                DateTime time = DateTime.Now;
                Console.WriteLine("Time:" + time.Hour + ":" + time.Minute + ":" + time.Second);
            }
        }
    }

}
