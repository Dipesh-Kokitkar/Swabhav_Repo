using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
           SingleObject obj= SingleObject.getInstance();
            obj.ShowMessage();
        }
    }
}
