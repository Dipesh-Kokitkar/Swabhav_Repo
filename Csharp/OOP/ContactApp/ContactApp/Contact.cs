using System;

namespace ContactApp
{
    [Serializable]
    class Contact
    {
        private double _phonenumber;
        private string _name, _email, _address;

        public Contact(string name, double phonenumber, string email, string address)
        {
            _name = name;
            _phonenumber = phonenumber;
            _email = email;
            _address = address;
        }

        public double PhoneNumber
        {
            get { return _phonenumber; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Email
        {
            get { return _email; }
        }

        public string Address
        {
            get { return _address; }
        }
    }
}
