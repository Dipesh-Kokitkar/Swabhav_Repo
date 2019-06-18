using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonSolution
{
    class DataServer
    {
        private static DataServer _dataserver;

        private DataServer() {
            Console.WriteLine("Service created");
        }
        public void DoSomething() {
            Console.WriteLine("data service by "+GetHashCode());
        }

        public static DataServer GetInstance() {
            if (_dataserver == null) {
                _dataserver = new DataServer();
            }
            return _dataserver;
        }
    }
}
