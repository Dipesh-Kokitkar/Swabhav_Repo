﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class LimitExceedException:Exception
    {
        public LimitExceedException(string message) : base(message) { }
    }
}
