using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactoryLib
{
    public class AutoMobileFactory
    {
        private static AutoMobileFactory _factory;

        private AutoMobileFactory() { }

        public static AutoMobileFactory GetInstance() {
            if (_factory == null)
                _factory = new AutoMobileFactory();
            return _factory;
        }

        public IAutomobile Make(AutoType type) {
            if (type == AutoType.AUDI)
                return new Audi();
            if (type == AutoType.BMW)
                return new BMW();
            if (type == AutoType.TESALA)
                return new Tesala();
            return null;
        }
    }
}
