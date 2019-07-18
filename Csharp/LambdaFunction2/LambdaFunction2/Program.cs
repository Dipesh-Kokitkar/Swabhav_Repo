using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaFunction2
{
    class Program
    {
        static void Main(string[] args)
        {
            CubeEvenNumber(2,
                (result) => Console.WriteLine("Result:" + result),
                (error) => Console.WriteLine("Error:" + error)
                );
            Predicate<int> isPrime = (num) =>
            {

                int counter = 0;
                for (int i = num; i >= 1; i--)
                {
                    if (num % i == 0)
                    {
                        counter = counter + 1;
                    }
                }
                if (counter == 2)
                {
                    return true;
                }

                return false;
            };

            Console.WriteLine("Result:"+isPrime(7));
        }
        static void CubeEvenNumber(int number, Action<string> fnsucess, Action<string> fnerror)
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
