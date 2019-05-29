using System;
using System.Collections.Generic;
using System.Text;

namespace PassByValueApp
{
    class Program
    {
        private static void ChangeToZero(int newMark) {
            newMark = 0;
        }
        private static void ChangeToZero(int[] newMarks)
        {
            for (int i=0;i<newMarks.Length;i++) {
                newMarks[i] = 0;
            }
        }
        static void Main(string[] args)
        {
            int mark = 100;
            int[] marks = { 10, 20, 30 };
            Console.WriteLine("before calling zero function:"+mark);
            ChangeToZero(mark);
            Console.WriteLine("After Calling :"+mark);

            ChangeToZero(marks);
            Console.WriteLine("after calling function for arr:");
            foreach(int m in marks)
                Console.WriteLine(m);
        }
    }
}
