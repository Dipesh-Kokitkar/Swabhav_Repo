using System;
using System.Collections.Generic;
using System.Linq;
using InventroyApp2;
using System.Text;

namespace InventoryApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitaliztionInventory(inventory);

            Instrument instrument = inventory.GetInstrument("11277");
            DisplayInstrumentInformation(instrument);

            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add("Model", "CJ");
            properties.Add("Builder", Builder.COLLINGS);

            InstrumentSpec searchspec = new InstrumentSpec(properties);

            Console.WriteLine();
            Console.WriteLine("Search result:");
            Console.WriteLine();

            List<Instrument> result = inventory.Search(searchspec);
            foreach (Instrument instrument1 in result)
            {
                DisplayInstrumentInformation(instrument1);
            }
        }

        static void InitaliztionInventory(Inventory inventory)
        {
            Dictionary<string, object> instrumentspec1 = new Dictionary<string, object>();
            instrumentspec1.Add("Instrument Type", InstrumentType.GUITAR);
            instrumentspec1.Add("Builder", Builder.COLLINGS);
            instrumentspec1.Add("Model", "CJ");
            instrumentspec1.Add("Type", GType.ACOUSTIC);
            instrumentspec1.Add("NumString", 12);
            instrumentspec1.Add("Topwood", Wood.INDIAN_ROSEWOOD);
            instrumentspec1.Add("Backwood", Wood.SITKA);

            inventory.AddInstrument("11277", 3999.5, new InstrumentSpec(instrumentspec1));

        }

        static void DisplayInstrumentInformation(Instrument instrument)
        {

            Console.WriteLine("Instrument Information");
            Console.WriteLine("Serial No;" + instrument.SerialNumber);
            Dictionary<string, object> properties = instrument.InstrumentSpecifiction.Properties;

            foreach (KeyValuePair<string, object> property in properties)
            {
                Console.WriteLine(property.Key + ":" + property.Value);
            }
            Console.WriteLine("price:" + instrument.Price);
        }
    }
}
