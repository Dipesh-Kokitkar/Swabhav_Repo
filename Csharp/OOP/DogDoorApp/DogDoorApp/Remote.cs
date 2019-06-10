using System.Timers;
using System.Threading;

namespace DogDoorApp
{
    class Remote
    {
        private DogDoor _door;
        private Thread _closedoor;

        public Remote(DogDoor door)
        {
            _closedoor = new Thread(AutoDoorClose);
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
            _closedoor.Start();
        }

        public void AutoDoorClose() {
            Thread.Sleep(5000);
            _door.Close();
            System.Console.WriteLine("Door is closed!");
            _closedoor.Abort();
        }
    }
}
