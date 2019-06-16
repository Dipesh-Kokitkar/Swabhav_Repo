using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventroyApp2
{
    class Inventory
    {
        private List<Instrument> _inventory;

        public Inventory()
        {
            _inventory = new List<Instrument>();
        }

        public void AddInstrument(string serialno, double price, InstrumentSpec spec)
        {
            Instrument instrument = null;
            if (spec is GuitarSpec)
                instrument = new Guitar(serialno,price,(GuitarSpec)spec);
            if (spec is MandolinSpec)
                instrument = new Mandolin(serialno, price, (MandolinSpec)spec);
            _inventory.Add(instrument);
        }

        public Instrument GetInstrument(string serialno)
        {
            foreach (Instrument instrument in _inventory)
            {
                if (instrument.SerialNumber.Equals(serialno))
                {
                    return instrument;
                }
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpec searchGuitar)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            for (int i=0;i<_inventory.Count;i++)
            {
                if (_inventory[i] is Guitar)
                {
                    Guitar G = (Guitar)_inventory[i];
                    if (G.Specification.matches(searchGuitar))
                        matchingGuitars.Add(G);
                }
            }
            return matchingGuitars;
        }

        public List<Mandolin> Search(MandolinSpec searchGuitar)
        {
            List<Mandolin> matchingmandoline = new List<Mandolin>();
            for(int i=0;i<_inventory.Count;i++)
            {
                if (_inventory[i] is Mandolin)
                {
                    Mandolin M = (Mandolin)_inventory[i];
                    if (M.Specification.matches(searchGuitar))
                        matchingmandoline.Add(M);
                }
            }
            return matchingmandoline;
        }

    }
}

