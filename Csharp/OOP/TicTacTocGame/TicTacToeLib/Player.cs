using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
    public class Player
    {
        private readonly string _name;
        private readonly Mark _mark;

        public Player(string name, Mark mark)
        {
            _name = name;
            _mark = mark;
        }

        public string PlayersName
        {
            get { return _name; }
        }
        public Mark PlayersMark
        {
            get { return _mark; }
        }
    }
}

