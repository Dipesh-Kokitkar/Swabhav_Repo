using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
    public class Board
    {
        private Cell[] _cell;

        public Board()
        {
            _cell = new Cell[9];
            for (int i = 0; i < 9; i++)
                _cell[i] = new Cell();
        }

        public void SetMark(int position, Mark mark)
        {
            _cell[position].Mark = mark;
        }

        public Mark GetMark(int Position)
        {
            return _cell[Position].Mark;
        }

        public bool IsBordEmpty()
        {
            foreach (Cell cell in _cell)
            {
                if (cell.IsAlreadyMark())
                    return false;
            }
            return true;
        }

        public bool IsBoardFull()
        {
            foreach (Cell cell in _cell)
            {
                if (!cell.IsAlreadyMark())
                    return false;
            }
            return true;
        }
    }
}

