using System;

namespace DogDoorApp
{
    class DogDoor
    {
        private bool _open;

        public DogDoor()
        {
            this._open = false;
        }

        public void Open()
        {
            _open = true;
        }

        public void Close()
        {
            _open = false;
        }

        public bool IsOpen()
        {
            return _open;
        }
    }
}
