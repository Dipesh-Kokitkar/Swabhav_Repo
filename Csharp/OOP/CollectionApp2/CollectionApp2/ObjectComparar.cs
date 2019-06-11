using System;
using System.Collections.Generic;
using CollectionApp;
using System.Linq;
using System.Text;

namespace CollectionApp2
{
    class ObjectComparar : IEqualityComparer<LineItem>
    {
        public bool Equals(LineItem x, LineItem y)
        {
            if (x.GetHashCode() == y.GetHashCode())
                return false;
            return true;
        }

        public int GetHashCode(LineItem obj)
        {
            return obj.ProductName.GetHashCode();
        }
    }
}
