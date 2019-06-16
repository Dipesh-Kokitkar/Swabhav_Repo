using System;
using ShoppingCartLib2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCartTest
{
    [TestClass]
    public class LineItemTest
    {
        [TestMethod]
        public void TestForLineItemIsWorkingOrNot1()
        {
            Product product = new Product(1001, "Lenova", 45000);
            LineItem lineitem = new LineItem(2000, 2, product);

            Assert.AreEqual(2000, lineitem.LineItemId);
            Assert.AreEqual(2, lineitem.LineItemQuantity);
            Assert.AreEqual(product, lineitem.GetProduct);
        }
    }
}
