using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace ContactApp
{
    class ContactStore
    {
        private ArrayList _list;
        public ContactStore()
        {
            _list = new ArrayList();
        }

        public void Serailzation(ArrayList contactlist)
        {
            BinaryFormatter binaryformatter = new BinaryFormatter();
            FileStream fileout = new FileStream("Contacts.binary", FileMode.Create, FileAccess.Write);

            try
            {
                using (fileout)
                {
                    binaryformatter.Serialize(fileout, contactlist);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:" + e.Message);
            }
        }

        public ArrayList Deserilztion()
        {
            BinaryFormatter binaryformatter = new BinaryFormatter();
            FileStream filein = new FileStream("Contacts.binary", FileMode.Open, FileAccess.Read);
            try
            {
                using (filein)
                {
                    _list = (ArrayList)binaryformatter.Deserialize(filein);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message:" + e.Message);
            }
            return _list;
        }
    }
}
