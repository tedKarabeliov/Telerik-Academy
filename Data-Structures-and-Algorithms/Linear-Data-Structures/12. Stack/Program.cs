using System;
using System.Collections.Generic;

namespace StackDemo
{
    class Program
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>(153);
            for (int i = 0; i < 586; i++)
            {
                stack.Push(1);
            }
            int popped = stack.Pop();
            int peeked = stack.Peek();
        }
    }
}
