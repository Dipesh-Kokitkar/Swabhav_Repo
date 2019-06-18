using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToeLib;

namespace TicTacToeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] player = new Player[2];
            player[0] = new Player("Abc", Mark.O);
            player[1] = new Player("Xyz", Mark.X);

            Game game = new Game(player);

            do
            {
                DisplayBoard(game.BoardStatus);
                Console.WriteLine(player[game.WhoesTurn].PlayersName + "'s Turn!");
                Console.WriteLine("Enter cell number:");
                int cellnumber = Convert.ToInt32(Console.ReadLine());
                try
                {
                    game.Play(cellnumber);
                }
                catch(Exception e) {
                    Console.WriteLine("Message:"+e.Message);
                    Console.WriteLine("plz mark on empty cells");
                    continue;
                }
                Result result = game.GetResult(player[game.WhoesTurn].PlayersMark);
                if (result == Result.WIN)
                {
                    Console.WriteLine(player[game.WhoesTurn].PlayersName + " Win the Game");
                    Environment.Exit(0);
                }
                if (result == Result.DRAW)
                {
                    Console.WriteLine("Game is draw!");
                    Environment.Exit(0);
                }
                game.SwitchPlayer();
            } while (true);
        }

        public static void DisplayBoard(Board board)
        {
            Console.WriteLine();
            Console.WriteLine("   |   |   |");
            Console.WriteLine(" {0} | {1} | {2} ", board.GetMark(0), board.GetMark(1),
                board.GetMark(2));
            Console.WriteLine("___|___|___");

            Console.WriteLine("   |   |   |");
            Console.WriteLine(" {0} | {1} | {2} ", board.GetMark(3), board.GetMark(4),
                board.GetMark(5));
            Console.WriteLine("___|___|___");

            Console.WriteLine("   |   |   |");
            Console.WriteLine(" {0} | {1} | {2} ", board.GetMark(6), board.GetMark(7),
                board.GetMark(8));
            Console.WriteLine("   |   |   |");
            Console.WriteLine();
        }
    }
}
