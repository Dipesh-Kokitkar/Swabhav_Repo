using System;

namespace UrlInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = args[0];
            //string[] s1 = url.Split(new char[] {'/',':','.','?','&'});
            string[] s1 = url.Split(new char[] {'.','?'});
            Console.WriteLine("Company Name:"+s1[1]);

            String[] s2 = s1[s1.Length-1].Split(new char[] {'&','='});
            for (int i = 0; i < s2.Length; i++) {
                if (s2[i] == "developer")
                    Console.WriteLine("Developer:"+s2[i + 1]);
                if (s2[i] == "location")
                    Console.WriteLine("Location:"+s2[i+1]);
                    }
        }
    }
}
