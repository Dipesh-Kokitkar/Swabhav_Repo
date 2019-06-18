using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPatturn
{
    class Calculator
    {
        private IMathamaticalOperations _operation;

        public Calculator(IMathamaticalOperations opertion) {
            _operation = opertion;
        }

        public int ExecuteOperation(int number1, int number2) {
            return _operation.PerfromOperation(number1, number2);
        }
    }
}
