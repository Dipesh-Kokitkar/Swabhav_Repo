using System;
using System.Collections.Generic;
using System.Linq;
using InventroyApp2;
using System.Text;

namespace InventoryApp3
{
    class Inventory
    {
        private readonly List<Instrument> _inventory;

        public Inventory() {
            _inventory = new List<Instrument>();
        }

        public void AddInstrument(string serialnumber,double price,InstrumentSpec spec) {
            _inventory.Add(new Instrument(serialnumber, price, spec));
        }

        public Instrument GetInstrument(string serialnumber) {
            foreach (Instrument instrument in _inventory) {
                if (instrument.SerialNumber.Equals(serialnumber))
                    return instrument;
            }
            return null;
        }

        public List<Instrument> Search(InstrumentSpec spec) {
            List<Instrument> matchinginstruments = new List<Instrument>();

            foreach (Instrument instrument in _inventory) {
                if (instrument.InstrumentSpecifiction.Matches(spec))
                    matchinginstruments.Add(instrument);
            }
            return matchinginstruments;
        }
    }
}
