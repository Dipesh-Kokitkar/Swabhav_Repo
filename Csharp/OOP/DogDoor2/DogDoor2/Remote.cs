using System;
using System.Threading;

namespace DogDoor2
{
    class Remote
    {
        private DogDoor _door;

        public Remote(DogDoor door)
        {
            this._door = door;
        }

        public void PressButton()
        {
            if (_door.IsOpen())
            {
                _door.Close();
                return;
            }
            _door.Open();
            System.Console.WriteLine("Door is opened!");
        }

       
    }
}
