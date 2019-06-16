using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGeneratorApp
{
    class Product
    {
        private readonly int _id;
        private readonly string _name;
        private const double DISCOUNT = 0.3;
        private readonly double _cost;

        public Product(int id,string name,double cost) {
            _id = id;
            _name = name;
            _cost = cost;
        }

        public int ProductId {
            get { return _id; }
        }

        public string ProductName {
            get { return _name; }
        }

        public double ProductCost {
            get { return _cost; }
        }
        public double ProductDiscount {
            get { return _cost * DISCOUNT; }
        }

        public double TotalCost() {
            return _cost - ProductDiscount;
        }

        public override string ToString()
        {
            return "\n\n\tProduct Information\nProduct Id:"+ProductId+"\nProduct Name:"+ProductName+"\nProduct Price:"
                +ProductCost+"\nProduct Discount:"+ProductDiscount+"\nProduct Total Cost:"+TotalCost();
        }
    }
}
