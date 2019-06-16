using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalciLib
{
    public class Calculator
    {
        public int CalculateEvenCube(int number ) {

            if (number < 0)
                throw new NegitiveNumberException("Given number is Negitive");
            if (!(number % 2 == 0)) {
                throw new NotEvenNumberException("Given number is Odd");
            }
            return (int)Math.Pow(number, 3);
        }
    }
}
