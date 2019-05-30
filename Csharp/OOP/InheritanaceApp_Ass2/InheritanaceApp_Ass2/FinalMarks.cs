using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanaceApp_Ass2
{
    class FinalMarks : Student
    {
        private float percentage;
        FinalMarks(String name, int m1, int m2) : base(name, m1, m2) { }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            percentage = (float)((float)(m1 + m2) / 200) * 100;
            Console.WriteLine("Percentage:" + percentage);
        }
        public static void Main(string[] args)
        {
            FinalMarks f = new FinalMarks("ABC", 70, 90);
            f.DisplayInfo();
        }
    }
}
