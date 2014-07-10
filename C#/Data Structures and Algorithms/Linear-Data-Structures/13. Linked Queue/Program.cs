using System;
using System.Collections.Generic;

namespace LinkedQueueDemo
{
    class Program
    {
        static void Main()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            var dequeued = queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
