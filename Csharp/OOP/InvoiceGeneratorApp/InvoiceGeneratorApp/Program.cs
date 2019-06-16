using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //FinalTest();
            OrderClassTest();
            //ProductClassTest();
        }

        static void OrderClassTest() {
            
            Order order = new Order(45,new DateTime(2019,2,5));
            order.AddItem(1001, 2, new Product(2000, "Lenova", 45000));

            foreach(LineItem item in order.LineItemList)
                Console.WriteLine("\nId:"+item.LineItemId+"\nQuantity:"+item.LineItemQuantity);

            order.AddItem(1002, 2, new Product(2000, "Lenova", 45000));
            foreach (LineItem item in order.LineItemList)
                Console.WriteLine("\nId:" + item.LineItemId + "\nQuantity:" + item.LineItemQuantity);

            List<LineItem> list = order.LineItemList;
            Console.WriteLine(list.Count);
        }

        static void ProductClassTest() {
            Product laptop = new Product(2000,"Lenova",45000);
            Console.WriteLine("\nId:"+laptop.ProductId+"\nName:"+laptop.ProductName+"\nPrice:"+laptop.ProductCost+
                "\nDiscount amount:"+laptop.ProductDiscount+"\nTotal Cost:"+laptop.TotalCost());
        }

        private static void FinalTest()
        {
            Customer Customer = new Customer(1001, "ABC", "Thane");
            LineItem laptop = new LineItem(1001, 2, new Product(2000, "Lenova", 45000));
            LineItem mobile = new LineItem(1002, 3, new Product(3000, "Moto E4", 10000));

            Order order = new Order(123, new DateTime(2019, 01, 05));
            order.AddItem(laptop);
            order.AddItem(mobile);
            Customer.AddOrders(order);
            InvoiceGenerator genrate = new InvoiceGenerator(Customer);
            Console.WriteLine("\nInvoice");
            Console.WriteLine(genrate.PrintInvoice());
        }
    }
}
