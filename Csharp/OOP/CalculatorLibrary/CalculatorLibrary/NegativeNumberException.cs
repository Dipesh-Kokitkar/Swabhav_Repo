using System;

namespace CalculatorLibrary
{
    class NegativeNumberException:Exception
    {
        public NegativeNumberException(string message):base(message) { }
        public NegativeNumberException() { }
    }
}
