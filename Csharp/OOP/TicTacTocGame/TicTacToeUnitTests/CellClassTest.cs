using System;
using TicTacToeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToeUnitTests
{
    [TestClass]
    public class CellClassTest
    {
        [TestMethod]
        public void TestForCellIsWorkingOrNot()
        {
            Cell cell = new Cell();

            bool result = cell.IsAlreadyMark();
            Assert.AreEqual(false, result);

            cell.Mark = Mark.O;
            Assert.AreEqual(Mark.O,cell.Mark);
        }
    }
}
