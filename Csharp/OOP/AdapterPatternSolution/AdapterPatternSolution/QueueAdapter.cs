using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPatternSolution
{
    class QueueAdapter<T> : IQueue<T>,IEnumerable<T>
    {
        private LinkedList<T> _queue;

        public QueueAdapter()
        {
            _queue = new LinkedList<T>();
        }

        public int Count
        {
            get
            {
                return _queue.Count;
            }
        }

        public T Dequeue()
        {
            T item= _queue.First();
            _queue.RemoveFirst();
            return item;
        }

        public void Enqueue(T item)
        {
            _queue.AddLast(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _queue.GetEnumerator();
        }
    }
}
