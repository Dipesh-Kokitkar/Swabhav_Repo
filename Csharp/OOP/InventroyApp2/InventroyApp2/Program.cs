using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventroyApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            Initalaztion(inventory);

            ShowData(inventory.GetInstrument("G1001"));

            List<Guitar> guitarresult = inventory.Search(new GuitarSpec(Builder.FENDER, "abc", Type.ACOUSTIC, 6,
                Wood.ALDER, Wood.ALDER));
            foreach (Guitar guitar in guitarresult) {
                Console.WriteLine("\n\tInformation");
                Console.WriteLine("\nserial no:" + guitar.SerialNumber + "\nPrice:" + guitar.Price);
            }

            List<Mandolin> mandolinresult = inventory.Search(new MandolinSpec(Builder.COLLINGS, "LMN", Type.ELECTRIC,
                Style.A, Wood.ALDER, Wood.ALDER));
            foreach (Mandolin mandolin in mandolinresult)
            {
                Console.WriteLine("\n\tInformation");
                Console.WriteLine("\nserial no:" + mandolin.SerialNumber + "\nPrice:" + mandolin.Price);
            }
        }

        static void ShowData(Instrument instrument) {
            if (instrument is Guitar)
            {
                Guitar guitar =(Guitar) instrument;
                Console.WriteLine("\n\tInformation");
                Console.WriteLine("\nserial no:"+guitar.SerialNumber+"\nPrice:"+guitar.Price);
            }
            if (instrument is Mandolin) {
                Mandolin mandolin = (Mandolin)instrument;
                Console.WriteLine("\n\tInformation");
                Console.WriteLine("\nserial no:" + mandolin.SerialNumber + "\nPrice:" + mandolin.Price);
            }
        }

        private static void Initalaztion(Inventory inventory)
        {
            inventory.AddInstrument("G1001", 1000, new GuitarSpec(Builder.FENDER, "abc", Type.ACOUSTIC, 6,
                Wood.ALDER, Wood.ALDER));
            inventory.AddInstrument("G1002", 1200, new GuitarSpec(Builder.COLLINGS, "xyz", Type.ELECTRIC, 12,
                Wood.BRAZILIAN_ROSEWOOD, Wood.BRAZILIAN_ROSEWOOD));
            inventory.AddInstrument("M1002", 500, new MandolinSpec(Builder.COLLINGS, "LMN", Type.ELECTRIC,
                Style.A, Wood.ALDER, Wood.ALDER));
        }
    }
}
