using System;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public int GetAddition(int a,int b) {
            if (a < 0 && b < 0) {
                return a + b;
            }
            throw new NegativeNumberException("Given numbers are negative");
        } 
    }
}
