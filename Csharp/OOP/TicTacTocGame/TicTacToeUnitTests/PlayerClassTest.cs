using System;
using TicTacToeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToeUnitTests
{
    [TestClass]
    public class PlayerClassTest
    {
        [TestMethod]
        public void TestForPlayerIsWorkingOrNot()
        {
            Player player = new Player("Abc",Mark.O);

            Assert.AreEqual("Abc",player.PlayersName);
            Assert.AreEqual(Mark.O,player.PlayersMark);
        }
    }
}
