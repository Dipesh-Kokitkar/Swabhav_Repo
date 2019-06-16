using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using ShoppingCartLib2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCartTest
{
    [TestClass]
    public class ProductTest
    {
       
        [TestMethod]
        public void CheckProductAddedOrNot()
        {
            Product product = new Product(1001, "Lenova", 45000);

            Assert.AreEqual(1001, product.ProductId);
            Assert.AreEqual("Lenova", product.ProductName);
            Assert.AreEqual(45000d, product.ProductCost);
            Assert.AreEqual(31500d, product.TotalCost());
        }
    }
}
