using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPatturn
{
    class Multipliction : IMathamaticalOperations
    {
        public int PerfromOperation(int number1,int number2)
        {
            return number1 * number2;
        }
    }
}
