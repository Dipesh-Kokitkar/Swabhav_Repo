﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WelcomeFormApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            //Application.Run(new WelcomeForm());
            Application.Run(new CommanForm());
        }
    }
}
