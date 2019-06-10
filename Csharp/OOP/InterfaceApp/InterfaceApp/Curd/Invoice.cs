using System;

namespace InterfaceApp.Curd
{
    class Invoice:ICurdable
    {
        public string Create()
        {
            return "Records created in invoice DB";
        }

        public string Delete()
        {
            return "Records are deleted from invoice DB";
        }

        public string Read()
        {
            return "Records are read from invoice db";
        }

        public string Update()
        {
            return "Recods are updated in invoice DB";
        }
    }
}
