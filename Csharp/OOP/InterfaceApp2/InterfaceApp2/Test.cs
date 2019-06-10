using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp2
{
    class Test : ISubInterface
    {
        public void Foo()
        {
            Console.WriteLine("In Test Class");
        }

        int ISubInterface.Foo()
        {
            throw new NotImplementedException();
        }
    }
}
