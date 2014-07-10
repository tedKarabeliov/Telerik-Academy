using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Generic_List
{
    class GenericList<T>
        where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] elements;

        private int count = 0;
        private int capacity = 0;

        //Constructors
        public GenericList() : this(DefaultCapacity)
        {
        }

        public GenericList(int capacity)
        {
            elements = new T[capacity];
            this.capacity = capacity;
        }
        //

        //Indexator
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= elements.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return elements[index];
            }
        }
        //

        //Properties
        public int Count
        {
            get { return this.count; }
        }

        public int Capacity
        {
            get { return this.capacity; }
        }
        //

        //Methods

        private void Expand()
        {
            T[] tempElements = new T[elements.Length];
            for (int i = 0; i < count; i++)
            {
                tempElements[i] = elements[i];
            }

            capacity *= 2;
            elements = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                elements[i] = tempElements[i];
            }

        }

        public void Add(T element)
        {
            if (count == capacity)
            {
                Expand();
            }
            this.elements[count] = element;
            count++;
        }

        public void Insert(int insertIndex, T value)
        {
            if (insertIndex < 0 || insertIndex > count)
            {
                throw new IndexOutOfRangeException();
            }

            if (count == capacity)
            {
                Expand();
            }

            //Creates temporary array and copy elements in it
            T[] tempElements = new T[count];
            for (int i = 0; i < count; i++)
            {
                tempElements[i] = elements[i];
            }
            count++;

            //Creates and fills the new array
            for (int i = 0, k = 0; i < count; i++)
            {
                if (i == insertIndex)
                {
                    elements[i] = value;
                }
                else
                {
                    elements[i] = tempElements[k];
                    k++;
                }
            }
        }

        public void Remove(int removeIndex)
        {
            if (removeIndex < 0 || removeIndex >= count)
            {
                throw new IndexOutOfRangeException();
            }
            //Creates temporary array and copy elements in it
            T[] tempElements = new T[count - 1];
            for (int i = 0, k = 0; k < count; i++, k++)
            {
                if (i == removeIndex)
                {
                    k++;
                }
                tempElements[i] = elements[k];
            }

            //Creates and fills the new array
            count--;
            elements = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                elements[i] = tempElements[i];
            }
        }

        public void Clear()
        {
            Array.Clear(elements, 0, capacity);
            count = 0;
        }

        public int Find(T value)
        {
            return Array.IndexOf(elements, value);
        }

        public override string ToString()
        {
            if (count == 0)
            {
                return null;
            }
            StringBuilder builder = new StringBuilder();
            builder.Append(elements[0]);
            for (int i = 1; i < count; i++)
            {
                builder.Append(" " + elements[i]);
            }
            return builder.ToString();
        }

        public T Max()
        {
            T max = elements[0];
            for (int i = 1; i < count; i++)
            {
                if (elements[i].CompareTo(max) > 0)
                {
                    max = elements[i];
                }
            }
            return max;
        }

        public T Min()
        {
            T min = elements[0];
            for (int i = 1; i < count; i++)
            {
                if (elements[i].CompareTo(min) < 0)
                {
                    min = elements[i];
                }
            }
            return min;
        }
    }
}
