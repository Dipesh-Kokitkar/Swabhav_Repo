using System;

namespace Assignment1
{
    class Encapsulate
    {
        private int id, marks;
        private string name;

        public void setValues(int id,int marks,string name) {
            this.id = id;
            this.marks = marks;
            this.name = name;
        }
        public int getId() {
            return this.id;
        }
        public int getMarks() {
            return this.marks;
        }
        public string getName() {
            return this.name;
        }
        static void Main(string[] args)
        {
            Encapsulate s = new Encapsulate();
            s.setValues(1, 90, "Dsk");
            Console.WriteLine("ID:"+s.getId());
            Console.WriteLine("Name:"+s.getName());
            Console.WriteLine("Marks:"+s.getMarks());
        }
    }
}
