using System;

namespace InventroyApp2
{
    class Mandolin:Instrument
    {
        private string _serialNo;
        private double _price;
        private InstrumentSpec _spec;

        public Mandolin(string serialno, double price, InstrumentSpec spec):base(serialno,price,spec)
        {
        }
    }
}
