using System;
using System.Collections.Generic;
using System.Threading;

namespace DogDoorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Thread Test = new Thread(DogComeBacks);

            Console.WriteLine("Dog is barking...to go out!");

            remote.PressButton();
            Console.WriteLine("Button is pressed....");
            Test.Start();

        }
        static void DogComeBacks() {
            Console.WriteLine("Dog goes out....!");
            Thread.Sleep(2000);
            Console.WriteLine("Dog comes inside!");
        }
    }
}
