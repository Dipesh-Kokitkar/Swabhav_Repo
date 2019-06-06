using System;

namespace HumanApp
{
    [Serializable]
    class Human
    {
        private readonly string _name;
        private float _height, _weight;
        private readonly int _age;
        private string _gender;

        public Human(String name, float height, float weight, int age, string Gender) : this(name, height, weight, age) {
            if (Gender.ToUpper().Equals("F") || Gender.ToLower().Equals("M"))
                this._gender = Gender;
        }
        public Human(string name, float height, float weight) : this(name, height, weight, 18) { }

        public Human(string name, float height, float weight, int age)
        {

            this._name = name;
            this._height = height;
            this._weight = weight;
            this._age = age;
            this._gender = "M";
        }


        public string GetName() { return _name; }
        public float GetHeight() { return _height; }
        public float GetWeight() { return _weight; }
        public int GetAge() { return _age; }
        public string GetGender() { return _gender; }

        public void Workout()
        {
            _weight -= (_weight * (2f / 100f));
        }
        public void Eat()
        {
            _height += (_height * (1f / 100f));
            _weight += (_weight * (5f / 100f));
        }
    }
}
