using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGeneratorApp
{
    class Customer
    {
        private readonly int _id;
        private readonly string _name;
        private readonly string _location;
        //private readonly Order _order;
        private readonly List<Order> _orders;

        public Customer(int id,string name,string location) {
            _id = id;
            _name = name;
            _location = location;
            _orders = new List<Order>();
        }

        public int CustomerId {
            get { return _id; }
        }

        public string CustomerName {
            get { return _name; }
        }

        public string CustmoerLocation {
            get { return _location; }
        }

        public void AddOrders(int id, DateTime date)
        {
            _orders.Add(new Order(id, date));
        }

         public void AddOrders(Order order)
        {
            _orders.Add(order);
        }

        public List<Order> orderlist {
            get { return _orders; }
        }
    }
}
