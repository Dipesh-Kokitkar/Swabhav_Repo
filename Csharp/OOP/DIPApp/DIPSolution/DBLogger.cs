﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPSolution
{
    class DBLogger : ILog
    {
        public void log(string message)
        {
            Console.WriteLine(message+" This message is write on DB");
        }
    }
}
