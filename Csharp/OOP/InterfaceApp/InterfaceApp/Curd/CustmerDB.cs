using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp.Curd
{
    class CustmerDB:ICurdable
    {
        public string Create() {
            return "Records created in custmer DB";
        }

        public string Read() {
            return "Records are read from custmer DB";
        }
        public string Update() {
            return "Recods are updated in customer DB";
        }

        public string Delete() {
            return "Records are deledted from cutmer db";
        }
    }
}
