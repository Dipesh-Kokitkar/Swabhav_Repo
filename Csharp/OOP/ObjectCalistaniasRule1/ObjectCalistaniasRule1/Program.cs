using System;

namespace ObjectCalistaniasRule1
{
    class Program
    {
        static void Main(string[] args)
        {
            Voilation voilation = new Voilation();
            voilation.ArrayIntaliztion();

            Console.WriteLine("voilation is Diagonal Array:"+voilation.IsDiagonal());

            Solution solution = new Solution();
            solution.ArrayIntaliztion();

            Console.WriteLine("Solution is Diagonal:"+solution.IsDiagonal());
        }
    }
}
