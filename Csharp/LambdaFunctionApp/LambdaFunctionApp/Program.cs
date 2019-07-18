using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaFunctionApp
{
    class Program
    {
        public delegate void Dcallback(string s);
        static void Main(string[] args)
        {
            CubeEvenNumber(3, 
                (result) => Console.WriteLine("Result:" + result),
                (error) => Console.WriteLine("Error:" + error)
                );
            Dcallback foo = (str) => { Console.WriteLine(str); };
            foo("hiii");
        }
        static void CubeEvenNumber(int number, Dcallback fnsucess, Dcallback fnerror)
        {
            if (number % 2 == 0)
            {
                fnsucess("" + number * number * number);
            }
            else
            {
                fnerror("NOT EVEN NUMBER");
            }
        }
    }
}
