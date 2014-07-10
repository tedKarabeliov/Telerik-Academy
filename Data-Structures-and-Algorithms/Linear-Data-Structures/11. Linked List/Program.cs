using System;
using System.Collections.Generic;
namespace LinkedListDemoo
{
    public class Program
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(5);
            list.AddLast(6);
            list.AddLast(7);
            list.AddLast(8);
            list.AddFirst(4);
            list.AddFirst(3);
            list.AddLast(9);
            list.Remove(4);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

