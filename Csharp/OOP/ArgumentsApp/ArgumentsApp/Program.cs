using System;

namespace ArgumentsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                foreach(String a in args) {
                    Console.WriteLine("hello "+a);
                }
            }
            else {
                Console.WriteLine("No parameter found!");
            }
        }
    }
}
