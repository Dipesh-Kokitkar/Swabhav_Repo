using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    public class GameOn
    {
        private int rand_num,guess_num;
        Random R = new Random();
        public GameOn() {
            rand_num = R.Next(1,100);
            Console.WriteLine("random:"+rand_num);
        }
        public int GameStart() {
            do
            {
                Console.WriteLine("Guess one number between 1 to 100 or enter -1 to return into Main Meun:");
                guess_num = Convert.ToInt32(Console.ReadLine());
                if (guess_num == -1) {
                    return -1;
                }

                if (CheckGuess(guess_num) == 1)
                    return 1;
         
            } while (true);

        }
        public int CheckGuess(int guess_num) {
            if (guess_num > rand_num)
            {
                Console.WriteLine("You are too far!Try again.");
                return 0;
            }
            else if (guess_num < rand_num)
            {
                Console.WriteLine("You are too close!Try again.");
                return 0;
            }
            else
            {
                Console.WriteLine("Yes! Your Guess is Correct!");
                return 1;
            }
        }
    }
}
