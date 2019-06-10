using System;

namespace CollageApp.Entity
{
    class Person
    {
        private readonly string _name, _dateofbirth, _address;
        private int _age;

        public Person(string name, string dateofbirth, string address)
        {
            _name = name;
            _dateofbirth = dateofbirth;
            _address = address;
        }

        public string Name
        {
            get { return _name; }
        }

        public string DateOfBirth
        {
            get { return _dateofbirth; }
        }

        public string Address
        {
            get { return _address; }
        }

        public int GetAge()
        {
            string[] date = _dateofbirth.Split('-');
            DateTime todaysdate = DateTime.Now;
            _age = (todaysdate.Year - Convert.ToInt32(date[2]));
            return _age;
        }
    }
}
