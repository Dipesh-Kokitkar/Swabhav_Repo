using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulateApp
{
    class Encapsulate
    {
        private int m1, m2, m3;
        private string name;
        public void setMarks(int m1, int m2, int m3)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }
        public void setName(string name) { this.name = name; }

        public int getM1() { return this.m1; }
        public int getM2() { return this.m2; }
        public int getM3() { return this.m3; }
        public string getName() { return this.name; }
        public float getPercentage()
        {
            float res = (((float)this.m1 + (float)this.m2 + (float)this.m3) / 300) * 100;
            return res;
        }
        public static void Main(string[] arg)
        {
            Encapsulate s1 = new Encapsulate();
            s1.setMarks(70, 80, 90);
            s1.setName("ABC");

            Console.WriteLine("Student Info:");
            Console.WriteLine("Name:" + s1.getName());
            Console.WriteLine("M1:" + s1.getM1() + "\nM2:" + s1.getM2() + "\nM3:" + s1.getM3());
            Console.WriteLine("Percentage:" + s1.getPercentage());
        }
    }
}
