using System;
using System.Threading;
namespace DogDoor2
{
    class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Thread test = new Thread(DogStop);
            door.AddAllowedBrak(new Bark("rowlf"));
            door.AddAllowedBrak(new Bark("roowlf"));
            door.AddAllowedBrak(new Bark("rawlf"));
            door.AddAllowedBrak(new Bark("woof"));

            BarkRecognzition recogniztion = new BarkRecognzition(door);
            Remote remote = new Remote(door);

            Console.WriteLine("Dog started barking...!!");
            recogniztion.Recognize(new Bark("rowlf"));

            Console.WriteLine("Dog goes outside!!!");
            test.Start();
            Console.WriteLine("Dog comes inside");


        }

        static void DogStop() {
            Thread.Sleep(2000);
            Console.WriteLine("Dog did his work");
        }
    }
}
