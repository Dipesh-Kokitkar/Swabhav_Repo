using System;
using ShoppingCartLib2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCartTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestForCustomerIsWorkingOrNot()
        {
            Order order = new Order(1001, new DateTime(2019, 6, 12));
            order.AddItem(2000, 2, new Product(1000, "Abc", 2500));
            order.AddItem(2001, 3, new Product(1002, "XYZ", 3000));

            Customer customer = new Customer(10, "LMN", "Mumbai");

            Assert.AreEqual(10, customer.CustomerId);
            Assert.AreEqual("LMN", customer.CustomerName);
            Assert.AreEqual("Mumbai", customer.CustmoerLocation);
        }

        [TestMethod]
        public void TestForCustomerIsProperlyAddedorderOrNot()
        {

            Order order = new Order(1001, new DateTime(2019, 6, 12));
            order.AddItem(2000, 2, new Product(1000, "Abc", 2500));
            order.AddItem(2001, 3, new Product(1002, "XYZ", 3000));

            Customer customer = new Customer(10, "LMN", "Mumbai");

            foreach (Order order1 in customer.orderlist)
                Assert.AreEqual(order, order1);
        }
    }
}
