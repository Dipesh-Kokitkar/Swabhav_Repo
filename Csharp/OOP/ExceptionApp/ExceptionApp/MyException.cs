using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionApp
{
    class MyException:Exception
    {
        public MyException(string message) {
            Console.WriteLine("User defined exception");
        }

        public virtual string ToString() {
            return base.ToString()+"UserException";
        }
    }
}
