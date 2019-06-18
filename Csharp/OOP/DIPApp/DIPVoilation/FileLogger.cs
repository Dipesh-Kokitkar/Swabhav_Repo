using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPVoilation
{
    class FileLogger
    {
        public void Log(string errormessage) {
            Console.WriteLine(errormessage+" This message is stored on File");
        }
    }
}
