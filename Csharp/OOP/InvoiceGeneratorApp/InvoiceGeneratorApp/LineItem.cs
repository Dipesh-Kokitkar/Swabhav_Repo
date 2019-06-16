using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGeneratorApp
{
    class LineItem
    {
        private readonly int _id;
        private int _quantity;
        private readonly Product _product;

        public LineItem(int id,int quantity,Product product) {
            _id = id;
            _quantity = quantity;
            _product = product;
        }

        public int LineItemId {
            get { return _id; }
        }

        public int LineItemQuantity {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public Product GetProduct {
            get { return _product; }
        }

        public double TotalItemCost() {
            return _product.TotalCost()*LineItemQuantity;
        }

        public override string ToString()
        {
            return "\n\n\tLineItem Information\nLineItem Id:"+LineItemId+"\nQuantity:"+LineItemQuantity+
                "\nTotal Item Cost:"+TotalItemCost()+_product.ToString();
        }

    }
}
