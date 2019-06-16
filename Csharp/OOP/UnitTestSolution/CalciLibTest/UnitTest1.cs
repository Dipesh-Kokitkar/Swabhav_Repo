using System;
using CalciLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalciLibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForEvenNumber()
        {
            Calculator calculator = new Calculator();
            int result = calculator.CalculateEvenCube(2);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestForOddnumberException()
        {
            Calculator calculator = new Calculator();
            string message = "";
            try
            {
                int resultt = calculator.CalculateEvenCube(9);
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            Assert.AreEqual("Given number is Odd", message);
        }

        [TestMethod]
        public void TestForNegitiveNumberException() {
            Calculator calculator = new Calculator();
            string meaasge = "";
            try
            {
                int result = calculator.CalculateEvenCube(-5);
            }
            catch (Exception e) {
                meaasge = e.Message;
            }
            Assert.AreEqual("Given number is Negitive",meaasge);
        }

        [TestMethod]
        public void TestForZeroNumber() {
            Calculator calculator = new Calculator();
            int result = calculator.CalculateEvenCube(0);
            Assert.AreEqual(0,result);
        }
    }
}
