using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodLib2
{
    class TesalaFactory : IAutoFactory
    {
        private static TesalaFactory _tesalafactory;

        private TesalaFactory() { }

        public static TesalaFactory GetInstance() {
            if (_tesalafactory == null)
                _tesalafactory = new TesalaFactory();
            return _tesalafactory;
        }


        public IAutomobile Make()
        {
            return new Tesala();
        }
    }
}
