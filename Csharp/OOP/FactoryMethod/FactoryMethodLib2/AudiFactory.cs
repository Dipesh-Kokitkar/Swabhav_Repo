using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodLib2
{
    public class AudiFactory : IAutoFactory
    {
        private static AudiFactory _audifactory;

        private AudiFactory() { }

        public static AudiFactory GetInstance() {
            if (_audifactory == null)
                _audifactory = new AudiFactory();
            return _audifactory;
        }

        public IAutomobile Make()
        {
            return new Audi();
        }
    }
}
