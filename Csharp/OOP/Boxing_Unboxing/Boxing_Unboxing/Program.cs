using System;
namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boxing==>");
            int num = 10;
            Object obj = num;//boxing
            Console.WriteLine("num:"+num);
            Console.WriteLine("obj="+obj);
            Console.WriteLine("Unboxing==>");
            int num2 = (int)obj;
            Console.WriteLine("num2:"+num2);
        }
    }
}
