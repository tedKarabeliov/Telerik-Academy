using System;
using System.Collections.Generic;

namespace Set
{
    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        private const int InitialCapacity = 16;

        private LinkedList<KeyValuePair<K, T>>[] array;

        public HashTable()
        {
            this.Capacity = InitialCapacity;
            this.array = new LinkedList<KeyValuePair<K, T>>[this.Capacity];
        }

        public int Capacity { get; private set; }
        public int Count { get; private set; }

        public T this[K key]
        {
            get
            {
                var value = this.Find(key);
                return value;
            }

            set
            {
                this.Add(key, value);
            }
        } 

        public K[] Keys
        {
            get
            {
                var keys = new List<K>();
                for (int i = 0; i < this.array.Length; i++)
                {
                    if (this.array[i] != null)
                    {
                        foreach (var keyvalue in this.array[i])
                        {
                            keys.Add(keyvalue.Key);
                        }
                    }
                }

                return keys.ToArray();
            }
        }

        public void Add(K key, T value)
        {
            var pair = new KeyValuePair<K, T>(key, value);
            var index = Math.Abs(key.GetHashCode() % this.Capacity);
            if (this.array[index] == null)
            {
                this.array[index] = new LinkedList<KeyValuePair<K, T>>();
            }

            if (this.array[index].Count != 0)
            {
                var currentKeyvalueNode = this.array[index].First;
                while (currentKeyvalueNode != null)
                {
                    if (currentKeyvalueNode.Value.Key.Equals(key))
                    {
                        currentKeyvalueNode.Value = pair;
                        return;
                    }

                    currentKeyvalueNode = currentKeyvalueNode.Next;
                }
            }

            this.array[index].AddLast(pair);
            this.Count++;
            this.TryResize();
        }

        public T Find(K key)
        {
            var index = Math.Abs(key.GetHashCode() % this.Capacity);
            if (this.array[index] == null)
            {
                throw new ArgumentException("No element found with given key");
            }

            foreach (var keyvalue in this.array[index])
            {
                if (keyvalue.Key.Equals(key))
                {
                    return keyvalue.Value;
                }
            }

            throw new ArgumentException("No element found with given key");
        }

        public void Remove(K key)
        {
            var index = Math.Abs(key.GetHashCode() % this.Capacity);
            if (this.array[index] == null)
            {
                throw new ArgumentException("Element to remove not found");
            }

            foreach (var keyvalue in this.array[index])
            {
                if (keyvalue.Key.Equals(key))
                {
                    this.array[index].Remove(keyvalue);
                    this.Count--;
                    return;
                }
            }

            throw new ArgumentException("Element to remove not found");
        }

        public void Clear()
        {
            this.array = new LinkedList<KeyValuePair<K, T>>[this.Capacity];
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i] != null)
                {
                    foreach (var keyvalue in this.array[i])
                    {
                        yield return keyvalue;
                    }
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void TryResize()
        {
            if (this.Count >= this.Capacity * 0.75)
            {
                var allElements = new List<KeyValuePair<K, T>>();

                foreach (var keyvalue in this)
                {
                    allElements.Add(keyvalue);
                }

                this.Count = 0;
                this.Capacity *= 2;
                this.array = new LinkedList<KeyValuePair<K, T>>[this.Capacity];
                foreach (var keyvalue in allElements)
                {
                    this.Add(keyvalue.Key, keyvalue.Value);
                }
            }
        }
    }

}
