using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeApp
{
    public class File:IDiskItem
    {
        private readonly string _name;
        private readonly string _extension;
        private readonly int _size;

        public File(string name,string extension,int size) {
            _name = name;
            _extension = extension;
            _size = size;
        }

        public void Display(int level)
        {
            Console.WriteLine();
            //level++;
            for (int i = 0; i < level; i++) {
                Console.Write("  ");
            }
            Console.Write(_name + " " + _extension + " " + _size + "\n");
            Console.WriteLine();
        }
    }
}
