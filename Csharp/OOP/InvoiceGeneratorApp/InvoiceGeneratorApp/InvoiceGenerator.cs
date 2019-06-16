using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGeneratorApp
{
    class InvoiceGenerator
    {
        private readonly Customer _customer;

        public InvoiceGenerator(Customer customer)
        {
            _customer = customer;
        }

        string OrderInfo()
        {
            string invoice = "";
            List<Order> orderlist = _customer.orderlist;
            foreach (Order order in orderlist)
            {
                invoice += "\n\n\tOrder Information\nOrder Id:" + order.OrderId + "\nOrder Date:" + order.OrderDate;
                invoice += LineItemInfo(order.LineItemList);
            }
            return "\n\tCustomerInformation\n\nCustmer Id:" + _customer.CustomerId + "\nCustomer Name:" 
                + _customer.CustomerName+ "\nCustomer Loctions:" + _customer.CustmoerLocation + invoice;
        }
        public string LineItemInfo(List<LineItem> list)
        {
            string invoice = "";
            List<LineItem> lineitemlist = list;
            foreach (LineItem item in lineitemlist)
            {
                invoice += item.ToString();
            }
            return invoice;
        }

        public string PrintInvoice()
        {
            return OrderInfo();
        }

    }
}
