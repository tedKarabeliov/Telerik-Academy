using System;
using System.Collections.Generic;

namespace StackDemo
{
    public class Stack<T> : IEnumerable<T>
    {
        private const int DefaultCapacity = 100;

        private T[] array;
        private int count;

        public Stack()
            : this(DefaultCapacity) { }

        public Stack(int capacity)
        {
            this.array = new T[capacity];
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Push(T value)
        {
            if (count == array.Length)
            {
                T[] newArray = new T[this.array.Length * 2];
                for (int i = 0; i < this.array.Length; i++)
                {
                    newArray[i] = this.array[i];
                }
                this.array = newArray;
            }
            this.count++;
            this.array[count - 1] = value;
        }

        public T Pop()
        {
            this.count--;
            return this.array[this.count];
        }

        public T Peek()
        {
            return this.array[this.count - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.count; i++)
            {
                yield return this.array[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
