using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            InvoicePrinter invoiceprinter = new InvoicePrinter(new Invoice(101,"ABC",4500
                ,0.3,0.18));
            invoiceprinter.Print();
        }
    }
}
