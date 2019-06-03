using System;
using System.Collections;

namespace InventoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventroy(inventory);
            GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER,"Stratocastor",Type.ELECTRIC,12,Wood.ALDER,Wood.ALDER);
            ArrayList matchingGuitars = inventory.Search(whatErinLikes);

            if (matchingGuitars.Count >= 0) {
                Console.WriteLine("Erin,you might like these guitars:");
                foreach (Guitar guitar in matchingGuitars) {
                    GuitarSpec spec = guitar.GetSpec();
                    Console.WriteLine("We have a "+spec.GetBuilder()+" "+spec.GetModel()+" "+spec.Getnumstring() +" String "+
                        spec.Gettype()+" guitar:\n    "+
                        spec.GetBackwood()+" back and sides,\n    "+
                        spec.GetTopwood()+" top. \n You cac have it for only $"+
                        guitar.GetPrice()+"!\n  ----");
                }
            }
            else
                Console.WriteLine("Sorry, Erin We have nothing for you!");
        }
        static void InitializeInventroy(Inventory inventory) {
            inventory.AddGuitar("V9569", 1499.95,new GuitarSpec(Builder.FENDER,"Stratocastor",Type.ELECTRIC,12,Wood.ALDER,Wood.ALDER));
            inventory.AddGuitar("V9512",1549.95,new GuitarSpec(Builder.FENDER,"Stratocastor",Type.ELECTRIC,12,Wood.ALDER,Wood.ALDER));
        }
    }
}
