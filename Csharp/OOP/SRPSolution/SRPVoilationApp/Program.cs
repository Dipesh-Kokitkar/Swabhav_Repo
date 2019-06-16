using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPVoilationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(101,"Abc",4500,0.3,0.18);
            invoice.PrintInvoice();
        }
    }
}
