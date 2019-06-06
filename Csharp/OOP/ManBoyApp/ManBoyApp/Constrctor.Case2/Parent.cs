using System;
using System.Collections.Generic;
using System.Text;

namespace ManBoyApp.Constrctor.Case2
{
    class Parent
    {
       private int _bar;

        public Parent(int bar) {
            _bar = bar;
        }

        public int Bar {
            get { return _bar; }
        }
    }
}
