using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGeneratorApp
{
    class Order
    {
        private readonly int _id;
        private readonly DateTime _date;
        private readonly List<LineItem> _items;

        public Order(int id, DateTime date)
        {
            _id = id;
            _date = date;
            _items = new List<LineItem>();
        }

        public int OrderId
        {
            get { return _id; }
        }

        public string OrderDate
        {
            get { return _date.Day + "/" + _date.Month + "/" + _date.Year; }
        }

        public void AddItem(int id, int quantity, Product prodcut)
        {
            List<LineItem> oldlist = LineItemList;
            if (_items.Count == 0)
            {
                _items.Add(new LineItem(id, quantity, prodcut));
                return;
            }
            foreach (LineItem item in oldlist)
            {
                if (item.GetProduct.ProductId.Equals(prodcut.ProductId))
                {
                    int count = item.LineItemQuantity;
                    item.LineItemQuantity = count + quantity;
                    return;
                }
            }
            _items.Add(new LineItem(id, quantity, prodcut));
        }
        public void AddItem(LineItem lineItem)
        {
            _items.Add(lineItem);
        }
        public List<LineItem> LineItemList
        {
            get { return _items; }
        }

        public double CheckOutPrice()
        {
            double totalcost = 0;
            foreach (LineItem item in _items)
            {
                totalcost += item.TotalItemCost();
            }
            return totalcost;
        }

    }
}
