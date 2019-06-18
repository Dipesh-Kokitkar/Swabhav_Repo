using System;
using TicTacToeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToeUnitTests
{
    [TestClass]
    public class ResultAnalyzerTest
    {
        [TestMethod]
        public void TestForResultAnalyzerWorkingOrNot()
        {
            Board board = new Board();
            board.SetMark(3, Mark.O);
            ResultAnalyzer resultanalyzer = new ResultAnalyzer(board);
            Assert.AreEqual(Result.PROGRESS, resultanalyzer.Analyze(Mark.O));
        }

        [TestMethod]
        public void TestForVerticalWinCondition()
        {
            Board board = new Board();
            ResultAnalyzer resultanalyzer = new ResultAnalyzer(board);
            board.SetMark(0, Mark.O);
            board.SetMark(3, Mark.O);
            board.SetMark(6, Mark.O);

            Assert.AreEqual(Result.WIN, resultanalyzer.Analyze(Mark.O));
        }

        [TestMethod]
        public void TestForHorizontalWinCondition()
        {
            Board board = new Board();
            ResultAnalyzer resultanalyzer = new ResultAnalyzer(board);
            board.SetMark(1, Mark.O);
            board.SetMark(2, Mark.O);
            board.SetMark(0, Mark.O);

            Assert.AreEqual(Result.WIN, resultanalyzer.Analyze(Mark.O));
        }

    }
}
