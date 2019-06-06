using System;
using System.Collections;

namespace DisplayEvenOddApp
{
    class EvenOrOdd
    {
        private const int LOWERLIMT = 1;
        private const int UPPERLMIT = 100;

        public ArrayList GetEvenNumbers()
        {
            ArrayList even = new ArrayList();
            for (int i = LOWERLIMT; i <= UPPERLMIT; i++)
            {
                if (i % 2 == 0)
                    even.Add(i);
            }
            return even;
        }
        public ArrayList GetOddNumbers()
        {
            ArrayList odd = new ArrayList();
            for (int i = LOWERLIMT; i <= UPPERLMIT; i++)
            {
                if (i % 2 != 0)
                    odd.Add(i);
            }
            return odd;
        }
    }
}
