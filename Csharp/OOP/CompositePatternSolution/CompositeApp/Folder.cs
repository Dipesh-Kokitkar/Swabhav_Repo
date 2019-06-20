using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeApp
{
    public class Folder:IDiskItem
    {
        private readonly string _name;
        private List<IDiskItem> _contains;

        public Folder(string name) {
            _name = name;
            _contains = new List<IDiskItem>();
        }

        public void Display(int level)
        {
            
            for(int i=0;i<level;i++)
                Console.Write("  ");
            Console.Write("Name of Folder:"+_name+"\n");
            level++;
            foreach (IDiskItem item in ItemList) {
                item.Display(level);
                
            }
        }

        public void AddItems(IDiskItem item) {
            _contains.Add(item);
        }

        public List<IDiskItem> ItemList {
            get { return _contains; }
        }
    }
}
