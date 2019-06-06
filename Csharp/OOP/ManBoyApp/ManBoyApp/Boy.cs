using System;

namespace ManBoyApp
{
    class Boy:Man
    {
        public override void play() {
            Console.WriteLine("Boy is playing...");
        }

        public void eat() {
            Console.WriteLine("Eating...");
        }
    }
}
