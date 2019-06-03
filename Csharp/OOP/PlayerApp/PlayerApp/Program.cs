using System;
namespace PlayerApp
{
    class Program
    {
        static void PrintInfo(Player p)
        {
            Console.WriteLine("Player Info==>");
            Console.WriteLine("Id:" + p.GetId() + "\nName:" + p.GetName() + "\nGender:" + p.GetGender()+"\nAge:"+p.GetAge());
        }
        static void Main(string[] args)
        {
            //CaseStudy1();
            Player Sachine = new Player(1, "Sachine", GenderOption.MALE, 26);
            Player Virat = new Player(2, "Virat");

            PrintInfo(Sachine);
            PrintInfo(Virat);

            Player P1 = Sachine.WhoIsElder(Virat);
            Console.WriteLine("Elder: ");
            PrintInfo(P1);

        }

        private static void CaseStudy1()
        {
            Player P1 = new Player(1, "ABC", GenderOption.FEMALE);
            Player P2 = new Player(2, "XYZ");

            PrintInfo(P1);
            PrintInfo(P2);
        }
    }
}
