using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneToManyEFApp2.BusinessModel;

namespace OneToManyEFApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read key");
            Console.ReadKey();
            SwabhavDBContext db = new SwabhavDBContext();
            //InsertOpration(db);
            Display(db);
            //Update(db);
            //DisplayReverse(db);
            //AddingProduct(db);
            AddingProductAndCustomer(db);
        }

        public static void AddingProductAndCustomer(SwabhavDBContext db) {
            Customer customer = new Customer();
            customer.Name = "Manish";
            customer.Location = "Thane";
            customer.PhoneNumber = 123456789;
            

            Order order2 = new Order();
            //order2.CustomerName = "DSK";
            order2.Date = "22/07/2019";

            LineItem item2 = new LineItem();
            item2.Name = "Iphone Item";
            item2.Quantity = 2;
            item2.Order = order2;

            Product iphone = new Product();
            iphone.ProductName = "IPHONE-X";
            iphone.Price = 55000;
            iphone.Discount = 0.3f;

            item2.Product = iphone;

            order2.LineItems.Add(item2);

            customer.Orders.Add(order2);
            db.Customers.Add(customer);

            db.SaveChanges();
            Console.WriteLine("Product added!");
        }

        public static void Display(SwabhavDBContext db)
        {
            //Old(db);
            Guid id = Guid.Parse("96D47A2C-00D1-4CFD-B175-9809B2B97065");
            Order order = db.Orders.Find(id);
            //Console.WriteLine(order.CustomerName);
            Console.WriteLine(order.Date);
            foreach (var item in order.LineItems) {
                Console.WriteLine("\nProduct Name:"+item.Name+"\nQuantity:"+item.Quantity);
            }

        }

        

        private static void DisplayReverse(SwabhavDBContext db) {
            Guid id = Guid.Parse("A987189E-9DEB-407F-B396-322C39A63EC5");
            LineItem item = db.LineItems.Find(id);
            //Console.WriteLine(item.Order.CustomerName);
            Console.WriteLine(item.Order.Date);
        }

        private static void Update(SwabhavDBContext db)
        {
           // var id = db.Orders.Where((order) => order.CustomerName == "ABC").Select((order) => order.ID).Single();

            Order order1 = db.Orders.Find();

            //Console.WriteLine(id);

            foreach (LineItem item in order1.LineItems)
            {
                item.Quantity = 5;
            }
            db.SaveChanges();

        }

        private static void InsertOpration(SwabhavDBContext db)
        {
            Order order1 = new Order();
            //order1.CustomerName = "ABC";
            order1.Date = "22/7/2019";

            LineItem lineitem1 = new LineItem();
            lineitem1.Name = "Laptop";
            lineitem1.Quantity = 2;
            //lineitem1.Unitprice = 50000;
            lineitem1.Order = order1;

            order1.LineItems.Add(lineitem1);

            db.Orders.Add(order1);
            db.SaveChanges();
        }
    }
}
