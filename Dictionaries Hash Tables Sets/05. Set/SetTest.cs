using System;
using System.Collections.Generic;

namespace Set
{
    public class SetTest
    {
        static void Main()
        {
            var set = new HashedSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);

            var set1 = new HashedSet<int>();

            set1.Add(3);
            set1.Add(4);
            set1.Add(5);
            set1.Add(6);

            set.IntersectWith(set1);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
