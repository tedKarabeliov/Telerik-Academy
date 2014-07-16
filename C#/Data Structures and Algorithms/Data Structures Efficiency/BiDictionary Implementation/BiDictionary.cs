using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace BiDictionary_Implementation
{
    public class BiDictionary<K1, K2, T>
    {
        private MultiDictionary<K1, T> firstDictionary;
        private MultiDictionary<K2, T> secondDictionary;

        public BiDictionary()
        {
            this.firstDictionary = new MultiDictionary<K1, T>(true);
            this.secondDictionary = new MultiDictionary<K2, T>(true);
        }

        public void Add(K1 firstKey, K2 secondKey, T value)
        {
            this.firstDictionary.Add(firstKey, value);
            this.secondDictionary.Add(secondKey, value);
        }

        public void RemoveByFirstKey(K1 key)
        {
            this.firstDictionary.Remove(key);
        }

        public void RemoveBySecondKey(K2 key)
        {
            this.secondDictionary.Remove(key);
        }

        public void RemoveByBothKeys(K1 firstKey, K2 secondKey)
        {
            RemoveByFirstKey(firstKey);
            RemoveBySecondKey(secondKey);
        }

        public IEnumerable<KeyValuePair<K1, ICollection<T>>> FindByFirstKey(K1 firstKey)
        {
            return this.firstDictionary.FindAll(i => i.Key.Equals(firstKey));
        }

        public IEnumerable<KeyValuePair<K2, ICollection<T>>> FindBySecondKey(K2 secondKey)
        {
            return this.secondDictionary.FindAll(i => i.Key.Equals(secondKey));
        }

        public ICollection<object> FindAll(K1 firstkey, K2 secondKey)
        {
            var foundByFirstKey = FindByFirstKey(firstkey);
            var foundBySecondkey = FindBySecondKey(secondKey);
            ICollection<object> result = new List<object>();
            foreach (var item in foundByFirstKey)
            {
                result.Add(item);
            }
            foreach (var item in foundBySecondkey)
            {
                result.Add(item);
            }
            return result;
        }
    }
}