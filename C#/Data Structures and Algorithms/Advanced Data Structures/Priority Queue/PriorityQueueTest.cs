using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace PriorityQueue
{
    class PriorityQueueTest
    {
        static void Main()
        {
            var arr = new int[] { 5, 7, 3, 9, 13, 2, 5 };
            var queue = new PriorityQueue<int>(arr);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Enqueue(55);
            queue.Dequeue();
            var dequeued = queue.Dequeue();
        }
    }
}
