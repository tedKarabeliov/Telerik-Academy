using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Trie
{
    public class TrieNode
    {
        private string Prefix { get; set; }
        private IList<string> Items { get; set; }
        private IDictionary<string, TrieNode> ChildNodes { get; set; }
        private IEqualityComparer<string> Comparer { get; set; }

        public TrieNode() : this(StringComparer.CurrentCulture) { }
        public TrieNode(IEqualityComparer<string> comparer) : this(comparer, string.Empty) { }

        private TrieNode(IEqualityComparer<string> comparer, string prefix)
        {
            if (prefix == null)
                throw new ArgumentNullException("Invalid prefix");

            this.Prefix = prefix;
            this.Items = new List<string>();
            this.ChildNodes = new Dictionary<string, TrieNode>(comparer);
            this.Comparer = comparer;
        }

        public void Add(string word)
        {
            if (word == null)
                throw new InvalidOperationException("Cannot add null to list");

            if (word.Length < this.Prefix.Length
                || !this.Comparer.Equals(word.Substring(0, this.Prefix.Length), this.Prefix))
            {
                throw new ArgumentException("Parameter does not match prefix.");
            }

            this.Items.Add(word);

            if (word.Length > this.Prefix.Length)
            {
                string childKey = word.Substring(0, this.Prefix.Length + 1);
                if (!this.ChildNodes.ContainsKey(childKey))
                {
                    this.ChildNodes.Add(childKey, new TrieNode(this.Comparer, childKey));
                }

                this.ChildNodes[childKey].Add(word);
            }
        }

        public void AddRange(IEnumerable<string> words)
        {
            foreach (string word in words)
                this.Add(word);
        }

        public ReadOnlyCollection<string> FindMatches(string searchPrefix)
        {
            if (searchPrefix == null)
                throw new InvalidOperationException("Cannot search on null strings");

            if (this.Comparer.Equals(searchPrefix, this.Prefix))
            {
                return new ReadOnlyCollection<string>(this.Items);
            }
            else
            {
                string childKey = searchPrefix.Substring(0, this.Prefix.Length + 1);
                if (this.ChildNodes.ContainsKey(childKey))
                    return this.ChildNodes[childKey].FindMatches(searchPrefix);
                else
                    return new ReadOnlyCollection<string>(new string[0]); // empty list for no matches 
            }
        }
    }
}
