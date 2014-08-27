using System;
using System.Collections.Generic;

namespace LinkedQueueDemo
{
    public class LinkedQueue<T> : IEnumerable<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;

        public LinkedQueue()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public Node<T> First
        {
            get { return this.head; }
        }

        public Node<T> Last
        {
            get { return this.tail; }
        }

        public int Count
        {
            get { return this.count; }
        }
        public void Enqueue(T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.NextItem = this.head;
            this.head = newNode;
            count++;
            if (this.count == 1)
            {
                this.tail = this.head;
            }
        }

        public T Dequeue()
        {
            Node<T> currentElement = this.head;

            while (currentElement.NextItem != this.tail)
            {
                currentElement = currentElement.NextItem;
            }
            this.tail = currentElement;

            T erasedElementValue = this.tail.NextItem.Value;
            this.tail.NextItem = null;
            count--;
            return erasedElementValue;
        }


        public IEnumerator<T> GetEnumerator()
        {
            Node<T> currentNode = this.head;

            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.NextItem;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
