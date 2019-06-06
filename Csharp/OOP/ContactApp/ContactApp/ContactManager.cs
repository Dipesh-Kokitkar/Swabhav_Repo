using System;
using System.Collections;

namespace ContactApp
{
    class ContactManager
    {
        private ArrayList _contactlist;
        private ContactStore _contactstore;



        public ContactManager()
        {
            _contactlist = new ArrayList();
            _contactstore = new ContactStore();
        }
        public void AddNewContact(string name, double phonenumber, string email, string address)
        {
            _contactlist = _contactstore.Deserilztion();
            _contactlist.Add(new Contact(name, phonenumber, email, address));
            _contactstore.Serailzation(_contactlist);
        }

        public ArrayList ShowConatctList()
        {
            _contactlist = _contactstore.Deserilztion();
            return _contactlist;
        }
    }
}
