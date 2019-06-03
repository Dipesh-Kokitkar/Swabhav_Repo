using System;

namespace PlayerApp
{
    class Player
    {
        private int _id;
        private string _name;
        private int _age;
        private GenderOption _gender;

        public Player(int _id, string _name, GenderOption _gender)
        {
            this._id = _id;
            this._name = _name;
            this._gender = _gender;
            this._age = 18;
        }

        public Player(int id, string name) : this(id, name, GenderOption.MALE) { }

        public Player(int id, string name, GenderOption gender, int age) : this(id, name, gender) { this._age = age; }

        public int GetId() { return _id; }
        public string GetName() { return _name; }
        public GenderOption GetGender() { return _gender; }
        public int GetAge() { return _age; }
        public Player WhoIsElder(Player p)
        {
            if (this.GetAge() > p.GetAge())
                return this;
            else
                return p;
        }
    }
}
