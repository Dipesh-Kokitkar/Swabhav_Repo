using System;

namespace ManBoyApp
{
    class Man
    {
        public  void Walk() {
            Console.WriteLine("walking.....");
        }

        public virtual void play() {
            Console.WriteLine("Man is playing..!");
        }
    }
}
