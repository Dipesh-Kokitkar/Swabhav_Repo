using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPSolution2
{
    class NoFestival : IFestivalType
    {
        public double CalculateFestivalRate()
        {
            return 0.07;
        }
    }
}
