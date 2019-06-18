using System;
using TicTacToeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToeUnitTests
{
    [TestClass]
    public class BoardClassTest
    {
        [TestMethod]
        public void TestforBoardClassIsWorkingOrNot()
        {
            Board board = new Board();
            Assert.AreEqual(true,board.IsBordEmpty());

        }

        [TestMethod]
        public void TestForAddingMarkToCellIsWorkingorNot() {
            Board board = new Board();
            board.SetMark(1,Mark.X);
            Assert.AreEqual(Mark.X,board.GetMark(1));
        }

        [TestMethod]
        public void TestForIsBoardFullMethod() {
            Board board = new Board();
            Assert.AreEqual(false, board.IsBoardFull());
            for (int i = 0; i < 9; i++)
                board.SetMark(i,Mark.O);

            Assert.AreEqual(true,board.IsBoardFull());
        }
    }
}
