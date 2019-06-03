using System;

namespace InventoryApp
{
    class Guitar
    {
        private string _serialNo;
        private double _price;
        private GuitarSpec _spec;

        public Guitar(string serialno,double price,GuitarSpec spec) {
            _serialNo = serialno;
            _price = price;
            _spec = spec;
        }

        public string GetSerialNo() { return _serialNo; }
        public double GetPrice() { return _price; }
        public void SetPrice(double p) { _price = p; }
        public GuitarSpec GetSpec() { return _spec; }

    }
}
