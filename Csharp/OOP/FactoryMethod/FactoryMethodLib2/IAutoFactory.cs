﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodLib2
{
    public interface IAutoFactory
    {
        IAutomobile Make();
    }
}
