using System;
using System.Collections.Generic;
using System.Text;

namespace DogDoor2
{
    class Bark
    {
        private string _sound;

        public Bark(string sound) {
            _sound = sound;
        }

        public string Sound {
            get { return _sound; }
        }

        public bool Equals(Bark bark)
        {
            if (_sound.Equals(bark.Sound))
                return true;
            return false;
        }
    }
}
