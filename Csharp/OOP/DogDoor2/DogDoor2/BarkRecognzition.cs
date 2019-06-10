using System;
using System.Collections.Generic;

namespace DogDoor2
{
    class BarkRecognzition
    {
        private DogDoor _door;

        public BarkRecognzition(DogDoor door) {
            _door = door;
        }

        public void Recognize(Bark bark) {
            Console.WriteLine("Bark Recognizer:Heard a '"+bark.Sound+"'");
            List<Bark> allowedbarks = _door.AllowedBark;
            foreach (Bark allowedbark in allowedbarks ) {
                if (allowedbark.Equals(bark)) {
                    _door.Open();
                    return;
                }
            }
            Console.WriteLine("Sorry this dog is not allowed");
        } 
    }
}
