using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace BiDictionary_Implementation
{
    class Program
    {
        static void Main()
        {
            var dictionary = new BiDictionary<int, int, string>();
            dictionary.Add(5, 6, "Pesho");
            dictionary.Add(2, 5, "Misho");
            var blq = dictionary.FindAll(2, 6);
            foreach (var item in blq)
            {
                Console.WriteLine(item);
            }
        }
    }
}
