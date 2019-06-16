using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPSolution
{
    class InvoicePrinter
    {
        private readonly Invoice _invoice;
        public InvoicePrinter(Invoice invoice) {
            _invoice = invoice;
        }

        public void Print() {
            Console.WriteLine("\tInvoice");
            Console.WriteLine("\nId:" +_invoice.Id + "\nName:" + _invoice.Name + "\nCost:"
                + _invoice.Cost +"\n Cost After Discount:"+_invoice.CalculateCostAfterDiscount()
                +"\nFinal Cost:" +_invoice.CalculateFinalCost());
        }
    }
}
