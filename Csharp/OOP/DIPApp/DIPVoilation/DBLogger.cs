using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPVoilation
{
    class DBLogger
    {
        public void Log(string errormessage) {
            Console.WriteLine(errormessage+" This message is stored on DB");
        }
    }
}
