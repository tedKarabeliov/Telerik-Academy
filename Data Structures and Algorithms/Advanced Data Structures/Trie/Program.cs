using System;
using System.Collections.Generic;
using System.IO;

namespace Trie
{
    class Program
    {
        static void Main()
        {
            var trie = new TrieNode();
            var reader = new StreamReader("../../words.jok");
            var line = reader.ReadLine();
            while (line != null)
            {
                trie.AddRange(line.Split(new char[] {' ', ',', '.', ':'}, StringSplitOptions.RemoveEmptyEntries));
                line = reader.ReadLine();
            }

            Console.WriteLine(trie.FindMatches("know").Count);
            Console.WriteLine(trie.FindMatches("group").Count);
            Console.WriteLine(trie.FindMatches("a").Count);
        }
    }
}