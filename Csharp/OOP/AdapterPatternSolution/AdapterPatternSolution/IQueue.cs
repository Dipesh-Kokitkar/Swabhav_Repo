using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPatternSolution
{
    public interface IQueue<T>:IEnumerable<T>
    {
        void Enqueue(T item);
        T Dequeue();
        int Count {
            get;
        }
    }
}
