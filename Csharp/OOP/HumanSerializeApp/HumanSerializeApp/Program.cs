using System;
using HumanApp;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace HumanSerializeApp
{
    class Program
    {
        static void ShowInformation(Human human) {
            Console.WriteLine("\nDetails of Human");
            Console.WriteLine("Name:" + human.GetName() + "\nHeight:" + human.GetHeight()+"\nWeight:"+human.GetWeight()+
                "\nAge:"+human.GetAge());

        }
        static void SerializeList(ArrayList list) {
            BinaryFormatter binaryformatter = new BinaryFormatter();
            FileStream fileout = new FileStream("humanList.binary",FileMode.Create,FileAccess.Write);
            try
            {
                using (fileout)
                {
                    binaryformatter.Serialize(fileout, list);
                    Console.WriteLine("Serializtion Successful!");
                }
            }
            catch(Exception e) {
                Console.WriteLine("Message:"+e.Message);
            }
        }

        static ArrayList DeserializeList() {
            BinaryFormatter binaryformatter = new BinaryFormatter();
            FileStream filein = new FileStream("humanList.binary",FileMode.Open,FileAccess.Read);
            try
            {
                using (filein)
                {
                    return (ArrayList)binaryformatter.Deserialize(filein);
                }
            }
            catch (Exception e) {
                Console.WriteLine("Message:"+e.Message);
            }
            return null;
        }

        static void Main(string[] args)
        {
            Human human1 = new Human("Abc", 150, 50,30);
            Human human2 = new Human("Xyz", 145, 45, 25);

            ArrayList humanlist = new ArrayList();
            humanlist.Add(human1);
            humanlist.Add(human2);

            Console.WriteLine("\nSerization on process....");
            SerializeList(humanlist);

            Console.WriteLine("\nHuman do workout and eat ");
            human1.Workout();
            human2.Eat();

            ShowInformation(human1);
            ShowInformation(human2);

            Console.WriteLine("\nDeserializtion on process.....");
            ArrayList newhumanlist= DeserializeList();

            Console.WriteLine("\nafter Deserializtion :");
            foreach (Human human in newhumanlist)
                ShowInformation(human);
        }
    }
}
