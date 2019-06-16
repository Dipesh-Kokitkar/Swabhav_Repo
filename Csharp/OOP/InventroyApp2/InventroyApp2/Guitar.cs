using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventroyApp2
{
    class Guitar:Instrument
    {
        private string _serialNo;
        private double _price;
        private GuitarSpec _spec;

        public Guitar(string serialno, double price, GuitarSpec spec):base(serialno,price,spec)
        {
        }
    }
}
