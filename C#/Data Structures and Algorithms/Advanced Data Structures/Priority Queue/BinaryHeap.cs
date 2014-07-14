using System;
using System.Collections.Generic;

namespace PriorityQueue
{
    public class BinaryHeap<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private const int InitialCapacity = 32;

        private T[] heap;

        public BinaryHeap()
            : this(null)
        {
        }

        public BinaryHeap(IEnumerable<T> collection)
        {
            this.Capacity = InitialCapacity;
            this.heap = new T[this.Capacity];

            if (collection != null)
            {
                foreach (var item in collection)
                {
                    this.Insert(item);
                }
            }
        }

        public int Capacity { get; private set; }

        public int Count { get; private set; }

        public void Insert(T item)
        {
            this.heap[this.Count] = item;
            this.Count++;
            var itemIndex = this.Count - 1;
            if (itemIndex > 0)
            {
                var parentIndex = GetParentIndex(itemIndex);
                while (heap[parentIndex].CompareTo(item) < 0)
                {
                    Swap(itemIndex, parentIndex);
                    itemIndex = parentIndex;
                    parentIndex = GetParentIndex(itemIndex);
                }
            }

            TryResize();
        }

        public T DeleteMax()
        {
            var deleted = this.heap[0];
            this.heap[0] = this.heap[this.Count - 1];
            this.Count--;
            
            while (!(heap[0].CompareTo(heap[1]) >= 0 && heap[0].CompareTo(heap[2]) >= 0))
            {
                int biggerChildIndex = heap[1].CompareTo(heap[2]) > 0 ? biggerChildIndex = 1 : biggerChildIndex = 2;
                Swap(biggerChildIndex, 0);
            }

            return deleted;
        }

        private void TryResize()
        {
            if (this.Count == this.Capacity)
            {
                this.Capacity *= 2;
                this.Count = 0;
                var newHeap = new T[this.Capacity];
                foreach (var item in this.heap)
                {
                    newHeap[this.Count] = item;
                    this.Count++;
                }
                this.heap = newHeap;
            }
        }

        private void Swap(int firstIndex, int secondIndex)
        {
            var swapTemp = this.heap[firstIndex];
            this.heap[firstIndex] = this.heap[secondIndex];
            this.heap[secondIndex] = swapTemp;
        }

        private int GetParentIndex(int itemIndex)
        {
            return itemIndex / 2;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.heap[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
