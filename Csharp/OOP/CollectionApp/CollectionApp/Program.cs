using System;
using System.Collections;
using System.Collections.Generic;


namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();
            Case2();
        }

        static void Case1() {
            ArrayList cart = new ArrayList();

            cart.Add(new LineItem("Books",2,500));
            cart.Add(new LineItem("NoteBooks",4,50));
            cart.Add(new LineItem("pen",2,10));

            cart.Add("Abc");
            cart.Add(100);

            foreach (Object element in cart) {
                Console.WriteLine("\tElements");
                LineItem item =(LineItem) element;
                Console.WriteLine("\nName:"+item.ProductName+"\nQuantity:"+item.Quantity+
                    "Unit Price:"+item.UnitPrice+"\nTotal Price:"+item.CalculateTotal());
            }
        }

        static void Case2() {
            List<LineItem> cart = new List<LineItem>();
            cart.Add(new LineItem("Books", 2, 500));
            cart.Add(new LineItem("NoteBooks", 4, 50));
            cart.Add(new LineItem("pen", 2, 10));
            

            IEnumerable<LineItem> lists = cart;

            foreach (LineItem item in lists) {
                Console.WriteLine("\tElements");
                Console.WriteLine("\nName:" + item.ProductName + "\nQuantity:" + item.Quantity +
                    "\nUnit Price:" + item.UnitPrice+"\nTotal Price:"+item.CalculateTotal());
            }
        }

        static void Case3() {
            

        }
    }
}
