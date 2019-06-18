using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
    public class AlreadyMarkException:Exception
    {
        public AlreadyMarkException(string message) : base(message) { }
    }
}
