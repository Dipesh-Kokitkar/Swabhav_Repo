using System.Text;
using System.Collections.Generic;
using System.IO;

namespace ContactApp
{
    class ContactManager
    {
        private List<Contact> _contactlist;
        private ContactStore _contactstore;



        public ContactManager()
        {
            _contactlist = new List<Contact>();
            _contactstore = new ContactStore();
        }
        public void AddNewContact(string name, double phonenumber, string email, string address)
        {
            _contactlist = _contactstore.Deserilztion();
            _contactlist.Add(new Contact(name, phonenumber, email, address));
            _contactstore.Serailzation(_contactlist);
        }

        public List<Contact> ShowConatctList()
        {
            _contactlist = _contactstore.Deserilztion();
            return _contactlist;
        }

        public List<Contact> SearchContact(string searchkey) {
            List<Contact> conatactlist = _contactstore.Deserilztion();
            List<Contact> matchcontact = new List<Contact>();

            foreach (Contact contact in conatactlist) {
                string name = contact.Name;
                string phonenumber = contact.PhoneNumber.ToString();
                string email = contact.Email;
                if (name.Equals(searchkey) || email.Equals(searchkey) || phonenumber.Equals(searchkey)) {
                    matchcontact.Add(contact);
                }
            }
            return matchcontact;
        }

        public void ExportContact() {
            List<Contact> contactlist = _contactstore.Deserilztion();
            StringBuilder filecontect = new StringBuilder();
            foreach (Contact contact in contactlist) {
                filecontect.AppendLine(contact.Name+","+contact.PhoneNumber+","+contact.Email+","+contact.Address);
            }
            File.AppendAllText("contact.csv",filecontect.ToString());
        }
    }
}
