using System;

namespace GuessingGame
{
    public class GameOn
    {
        private int _randomnumber;

        public GameOn()
        {
            Random random = new Random();
            _randomnumber = random.Next(1, 100);
        }

        public int RandomNumber
        {
            get { return _randomnumber; }
        }

        public int CheckGuess(int guess_num)
        {
            if (guess_num > _randomnumber)
            {
                return 0;
            }
            if (guess_num < _randomnumber)
            {
                return -1;
            }
            return 1;
        }
    }
}
