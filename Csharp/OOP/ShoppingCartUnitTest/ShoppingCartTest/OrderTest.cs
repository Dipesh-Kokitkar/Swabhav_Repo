using System;
using ShoppingCartLib2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCartTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void TestForOrderIsWorkingOrNot()
        {
            Product product = new Product(1001, "Lenova", 45000);
            LineItem lineitem = new LineItem(2000, 2, product);

            Order order = new Order(100, new DateTime(2019, 6, 12));
            order.AddItem(lineitem);


            Assert.AreEqual(100, order.OrderId);
            Assert.AreEqual("12/6/2019", order.OrderDate);
            Assert.AreEqual(1, order.LineItemList.Count);
            Assert.AreEqual(63000d, order.CheckOutPrice());
        }

        [TestMethod]
        public void TestForDuplicateLineItemAndUpdateQuantity()
        {
            Product product = new Product(1001, "Lenova", 45000);

            Order order = new Order(100, new DateTime(2019, 6, 12));
            order.AddItem(2000, 2, product);
            order.AddItem(2001, 2, product);

            Assert.AreEqual(1, order.LineItemList.Count);

            foreach (LineItem item in order.LineItemList)
                Assert.AreEqual(4, item.LineItemQuantity);
        }
    }
}
