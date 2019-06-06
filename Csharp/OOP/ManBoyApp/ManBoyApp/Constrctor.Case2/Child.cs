using System;
using System.Collections.Generic;
using System.Text;

namespace ManBoyApp.Constrctor.Case2
{
    class Child:Parent
    {
        public Child():base(100) { }

        public Child(int bar) : base(bar) { }
    }
}
