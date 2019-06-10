using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp.Curd
{
    class DpartmentDB : ICurdable
    {
        public string Create()
        {
            return "Records created in dept DB";
        }

        public string Delete()
        {
            return "Records are deleted from dept DB";
        }

        public string Read()
        {
            return "Records are read from dept db";
        }

        public string Update()
        {
            return "Recods are updated in dept DB";
        }
    }
}
