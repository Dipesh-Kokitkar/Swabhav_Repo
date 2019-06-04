using System;

namespace CustomerApp
{
    class Customer
    {
        private int _id;
        private string _firstname, _lastname;
        private static int _nextid;

        static Customer(){
            _nextid = 1000;
            }

        public Customer(string firstname,string lastname) {
            _firstname = firstname;
            _lastname = lastname;
            _nextid += 1;
            _id = _nextid;
        }

        public int Id {
            get { return _id; }
        }
        public string FirstName {
            get { return _firstname; }
        }
        public string LastName {
            get { return _lastname; }
        }
    }
}
