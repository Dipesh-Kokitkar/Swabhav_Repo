using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
    public class Cell
    {
        private Mark _mark;

        public Cell()
        {
            _mark = Mark.E;
        }

        public Mark Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        public bool IsAlreadyMark()
        {
            if (Mark == Mark.O || Mark == Mark.X)
                return true;
            return false;
        }
    }
}

