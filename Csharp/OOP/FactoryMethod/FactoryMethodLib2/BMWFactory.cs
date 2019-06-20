using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodLib2
{
    public class BMWFactory : IAutoFactory
    {
        private static BMWFactory _bmwfactory;

        private BMWFactory() { }

        public static BMWFactory GetInstance() {
            if (_bmwfactory == null)
                _bmwfactory = new BMWFactory();
            return _bmwfactory;
        }

        public IAutomobile Make()
        {
            return new BMW();
        }
    }
}
