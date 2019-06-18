using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
    public class ResultAnalyzer
    {
        private readonly Board _board;

        public ResultAnalyzer(Board board)
        {
            _board = board;
        }

        public Result Analyze(Mark mark)
        {
            if (_board.GetMark(0) == mark && _board.GetMark(1) == mark && _board.GetMark(2) == mark)
                return Result.WIN;
            if (_board.GetMark(3) == mark && _board.GetMark(4) == mark && _board.GetMark(5) == mark)
                return Result.WIN;
            if (_board.GetMark(6) == mark && _board.GetMark(7) == mark && _board.GetMark(8) == mark)
                return Result.WIN;

            if (_board.GetMark(0) == mark && _board.GetMark(3) == mark && _board.GetMark(6) == mark)
                return Result.WIN;
            if (_board.GetMark(1) == mark && _board.GetMark(4) == mark && _board.GetMark(7) == mark)
                return Result.WIN;
            if (_board.GetMark(2) == mark && _board.GetMark(5) == mark && _board.GetMark(8) == mark)
                return Result.WIN;

            if (_board.GetMark(0) == mark && _board.GetMark(4) == mark && _board.GetMark(8) == mark)
                return Result.WIN;
            if (_board.GetMark(2) == mark && _board.GetMark(4) == mark && _board.GetMark(6) == mark)
                return Result.WIN;

            if (_board.IsBoardFull())
                return Result.DRAW;

            return Result.PROGRESS;

        }
    }
}

