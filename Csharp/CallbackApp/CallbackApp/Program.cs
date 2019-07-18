using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallbackApp
{
    public delegate void Dcallback(string s);
    class Program
    {
        static void Main(string[] args)
        {
            CubeEvenNumber(3, FnSucess, FnError);
        }

        static void CubeEvenNumber(int number, Dcallback fnsucess, Dcallback fnerror) {
            if (number % 2 == 0)
            {
                fnsucess("" + number * number * number);
            }
            else {
                fnerror("NOT EVEN NUMBER");
            }
        }

        static void FnSucess(string result) {
            Console.WriteLine("Result:"+result);
        }
        static void FnError(string error) {
            Console.WriteLine("Error:"+error);
        }
    }
}
