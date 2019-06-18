using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
    public class Game
    {
        private readonly Player[] _players;
        private Board _board;
        private readonly ResultAnalyzer _resultanalyzer;
        private int _switchplayer;

        public Game(Player[] player)
        {
            _players = player;
            _board = new Board();
            _resultanalyzer = new ResultAnalyzer(_board);
            _switchplayer = 0;
        }

        public Player[] Players
        {
            get { return _players; }
        }

        public Board BoardStatus {
            get { return _board; }
        }

        public Result GetResult(Mark mark)
        {
            return _resultanalyzer.Analyze(mark);
        }

        public int WhoesTurn {
            get { return _switchplayer; }
        }

        public void SwitchPlayer() {
            _switchplayer = _switchplayer == 0 ? 1 : 0;
        }
        public void Play(int position)
        {
            if (_board.GetMark(position) == Mark.O|| _board.GetMark(position) == Mark.X)
                throw new AlreadyMarkException("You can not mark this cell.It is already marked");
            _board.SetMark(position, _players[_switchplayer].PlayersMark);
        }
    }
}

