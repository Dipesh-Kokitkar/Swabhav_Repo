using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Console.WriteLine("\t\tGuessing Game");
            while (true) {
                Console.WriteLine("Main Meun");
                Console.WriteLine("1.Start Game\n2.Exit");
                Console.WriteLine("Select one option:");
                ch= Convert.ToInt32(Console.ReadLine());
                if (ch == 1)
                {
                    GameOn G = new GameOn();
                    if (G.GameStart() == 1)
                    {
                        Console.WriteLine("You Won the Game!");
                    }
                    else {
                        Console.WriteLine("For contiue select start or exit ");
                    }
                }
                else {
                    Environment.Exit(0);
                }
            }
        }
    }
}
