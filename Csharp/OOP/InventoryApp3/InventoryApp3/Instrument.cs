using System;
using System.Collections.Generic;
using System.Linq;
using InventroyApp2;
using System.Text;

namespace InventoryApp3
{
    class Instrument
    {
        private readonly string _serialnumber;
        private double _price;
        private InstrumentSpec _spec;

        public Instrument(string serialnumber,double price,InstrumentSpec instrumentspec) {
            _serialnumber = serialnumber;
            _price = price;
            _spec = instrumentspec;
        } 

        public string SerialNumber {
            get { return _serialnumber; }
        }

        public double Price {
            get { return _price; }
            set { _price = value; }
        }

        public InstrumentSpec InstrumentSpecifiction {
            get { return _spec; }
        }
    }
}
