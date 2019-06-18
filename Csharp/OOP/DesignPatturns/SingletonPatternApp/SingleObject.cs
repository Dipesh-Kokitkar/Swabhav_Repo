using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternApp
{
    class SingleObject
    {
        private static SingleObject obj=new SingleObject();

        private SingleObject(){ }

        public static SingleObject getInstance() {
            return obj;
        }

        public void ShowMessage() {
            Console.WriteLine("Hello");
        }

    }
}
