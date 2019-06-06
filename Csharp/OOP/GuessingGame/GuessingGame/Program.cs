using System;

namespace GuessingGame
{
    class Program
    {
        static int StartTheGame()
        {
            GameOn gameon = new GameOn();
            Console.WriteLine("Random Number:" + gameon.RandomNumber);
            do
            {
                Console.WriteLine("Guess one number between 1 to 100 or enter -1 to retrun into main menu:");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == -1)
                    return -1;
                int status = gameon.CheckGuess(number);
                if (status == 1)
                {
                    Console.WriteLine("Guess is right ! you Won the Game");
                    return 1;
                }
                if (status == 0)
                    Console.WriteLine("You are too far!Try again.");
                if (status == -1)
                    Console.WriteLine("You are too close!Try again.");

            } while (true);
        }
        static void Main(string[] args)
        {
            int ch;
            Console.WriteLine("\t\tGuessing Game");
            while (true)
            {
                Console.WriteLine("Main Meun");
                Console.WriteLine("1.Start Game\n2.Exit");
                Console.WriteLine("Select one option:");
                ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 1)
                {
                    StartTheGame();
                }
                if (ch == 2)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
