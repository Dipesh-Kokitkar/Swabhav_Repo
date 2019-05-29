using System;

namespace ConstuctorOverloadingAss1
{
    class Program
    {
        int subject1, subject2;
        string name;
        Program() {
            subject1 = 0;
            subject2 = 0;
            name = "xyz";
        }
        Program(int subject1, int subject2, string name) {
            this.subject1 = subject1;
            this.subject2 = subject2;
            this.name = name;
        }
        Program(double subject1, double subject2) {
            this.subject1=(int)subject1;
            this.subject2 = (int)subject2;
            this.name = "abc";
        }
        public void display() {
            Console.WriteLine("Name:"+name+"\nSubject1:"+subject1+"\nSubject2:"+subject2);
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            Program p2=new Program(80,90,"DSK");
            Program p3 = new Program(70.5,60.66);

            p1.display();
            p2.display();
            p3.display();
        }
    }
}
