using System;
using System.Collections.Generic;

namespace PriorityQueue
{
    public class PriorityQueue<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private BinaryHeap<T> binaryHeap;

        public PriorityQueue()
            : this(null)
        {
        }

        public PriorityQueue(IEnumerable<T> collection)
        {
            this.binaryHeap = new BinaryHeap<T>(collection);
        }

        public void Enqueue(T item)
        {
            this.binaryHeap.Insert(item);
        }

        public T Dequeue()
        {
            return this.binaryHeap.DeleteMax();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.binaryHeap)
            {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
