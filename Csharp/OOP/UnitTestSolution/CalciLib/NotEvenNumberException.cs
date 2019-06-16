using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalciLib
{
    public class NotEvenNumberException:Exception
    {
        public NotEvenNumberException(string message) : base(message) { }
    }
}
