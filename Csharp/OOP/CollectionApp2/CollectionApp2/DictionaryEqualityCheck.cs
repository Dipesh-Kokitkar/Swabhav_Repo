﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionApp2
{
    class DictionaryEqualityCheck : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null)
                return false;
            if (x.RollNumber == y.RollNumber)
                return true;
            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.RollNumber.GetHashCode();
        }
    }
}
