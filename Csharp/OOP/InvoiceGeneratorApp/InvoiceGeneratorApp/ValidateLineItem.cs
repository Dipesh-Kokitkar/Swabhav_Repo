using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGeneratorApp
{
    class ValidateLineItem : IEqualityComparer<LineItem>
    {
        public bool Equals(LineItem x, LineItem y)
        {
            if (x.GetProduct.ProductId.Equals(y.GetProduct.ProductId))
                return true;
            return false;
        }

        public int GetHashCode(LineItem obj)
        {
            throw new NotImplementedException();
        }
    }
}
