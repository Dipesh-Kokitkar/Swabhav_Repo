using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventroyApp2
{
    abstract class Instrument
    {
        private readonly string _serialnumber;
        private double _price;
        private readonly InstrumentSpec _spec;

        public Instrument(string serialnumber,double price,InstrumentSpec spec) {
            _serialnumber = serialnumber;
            _price = price;
            _spec = spec;
        }

        public string SerialNumber {
            get { return _serialnumber; }
        }

        public double Price {
            get { return _price; }
            set { _price = value; }
        }

        public InstrumentSpec Specification {
            get { return _spec; }
        }


    }
}
