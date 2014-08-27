using System;
using System.Collections.Generic;

namespace Set
{
    public class HashedSet<T> : IEnumerable<T>
    {
        private HashTable<T, T> table;
        private int count;

        public int Count
        {
            get
            {
                return this.table.Count;
            }
        }

        public HashedSet()
        {
            this.table = new HashTable<T, T>();
        }

        public void Add(T value)
        {
            this.table.Add(value, value);
        }

        public T Find(T key)
        {
            return this.table.Find(key);
        }

        public void Remove(T key)
        {
            this.table.Remove(key);
        }

        public bool Contains(T key)
        {
            try
            {
                this.Find(key);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public void Clear()
        {
            this.table.Clear();
        }

        public void UnionWith(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                this.Add(item);
            }
        }

        public void IntersectWith(IEnumerable<T> collection)
        {
            var intersectResult = new HashedSet<T>();
            foreach (var item in collection)
            {
                if (this.Contains(item))
                {
                    intersectResult.Add(item);
                }
            }

            this.Clear();
            foreach (var item in intersectResult)
            {
                this.Add(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var keyvalue in this.table)
            {
                yield return keyvalue.Value;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
