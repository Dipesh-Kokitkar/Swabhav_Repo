using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalciLib
{
    class NegitiveNumberException:Exception
    {
        public NegitiveNumberException(string message):base(message){ }
    }
}
