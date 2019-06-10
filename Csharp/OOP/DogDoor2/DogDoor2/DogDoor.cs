using System;
using System.Collections.Generic;
using System.Threading;

namespace DogDoor2
{
    class DogDoor
    {
        private bool _open;
        private Thread _autoclose;
        private List<Bark> _allowedbarks;

        public DogDoor()
        {
            _allowedbarks = new List<Bark>();
            _autoclose = new Thread(AutoDoorClose);
            this._open = false;
        }

        public void Open()
        {
            _open = true;
            Console.WriteLine("Door is opened!");
            _autoclose.Start();
        }

        public void Close()
        {
            _open = false;
            Console.WriteLine("Door is closed");
        }

        public bool IsOpen()
        {
            return _open;
        }

        public void AddAllowedBrak(Bark bark) {
            _allowedbarks.Add(bark);
        }

        public List<Bark> AllowedBark {
            get { return _allowedbarks; }
        }

        public void AutoDoorClose()
        {
            Thread.Sleep(5000);
            Close();
            _autoclose.Abort();
        }

    }
}
