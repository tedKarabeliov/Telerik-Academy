using System;
using System.Collections.Generic;

namespace LinkedQueueDemo
{
    public class Node<T>
    {
        private T value;
        private Node<T> nextItem;

        public Node(T value)
        {
            this.Value = value;
        }

        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public Node<T> NextItem
        {
            get { return this.nextItem; }
            set { this.nextItem = value; }
        }
    }
}
