using System;
using System.Collections.Generic;
using System.Collections;

namespace SetAndMapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryImplementation();
        }

        private static void DictionaryImplementation()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "Jan");
            dictionary.Add(2, "Feb");
            //dictionary.Add(new KeyValuePair<int, string>(3, "March"));
            dictionary.Add(3, "March");
            Console.WriteLine("\tAfter adding elements:");
            showElements(dictionary);

            Console.WriteLine("Count:" + dictionary.Count);
            Console.WriteLine("Is Jan is contain in dictionary:" + dictionary.ContainsValue("Jan"));

            dictionary.Remove(3);
            Console.WriteLine("After remove:");
            showElements(dictionary);
            //dictionary.Add(1, "xyz");
            dictionary[2] = "May";
            Console.WriteLine("After Upadte:");
            showElements(dictionary);

        }


        static void showElements(Dictionary<int, string> dictionary) {
           foreach(KeyValuePair<int,string> item in dictionary)
                Console.WriteLine("Key:"+item.Key+"\tValue:"+item.Value);
        }
    }
}
