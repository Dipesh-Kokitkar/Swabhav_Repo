using System;

namespace CollectionApp
{
    class LineItem
    {
        private readonly string _productname;
        private readonly int _quantity;
        private readonly double _unitprice;

        public LineItem(string name, int quantity, double price) {
            _productname = name;
            _quantity = quantity;
            _unitprice = price;
        }

        public double CalculateTotal() {
            return _unitprice * (double)_quantity;
        }

        public string ProductName {
            get { return _productname; }
        }

        public int Quantity {
            get { return _quantity; }
        }

        public double UnitPrice {
            get { return _unitprice; }
        }
    }
}
