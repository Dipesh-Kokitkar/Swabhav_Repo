using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSPSolution
{
    interface IShape
    {
        int CalculateArea();
        int Width {
            get;
            set;
        }
        int Height {
            get;
            set;
        }

    }
}
