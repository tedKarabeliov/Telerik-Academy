using System;
using System.Collections.Generic;
namespace LinkedListDemo
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private ListItem<T> firstElement;
        private ListItem<T> lastElement;
        private int count;

        public LinkedList()
        {
            this.firstElement = null;
            this.lastElement = null;
            this.count = 0;
        }

        public ListItem<T> First
        {
            get { return this.firstElement; }
        }

        public ListItem<T> Last
        {
            get { return this.lastElement; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public void AddFirst(T value)
        {
            if (this.firstElement != null)
            {
                ListItem<T> newFirstElement = new ListItem<T>(value);
                newFirstElement.NextItem = firstElement;
                firstElement = newFirstElement;
            }
            else
            {
                this.firstElement = new ListItem<T>(value);
                this.lastElement = firstElement;
            }
            count++;
        }

        public void AddLast(T value)
        {
            ListItem<T> newNode = new ListItem<T>(value);

            if (this.lastElement != null)
            {
                lastElement.NextItem = newNode;
                this.lastElement = newNode;
            }
            else
            {
                this.firstElement = newNode;
                this.lastElement = newNode;
            }
            count++;
        }

        public void AddBefore(ListItem<T> searchNode, T value)
        {
            if (searchNode == null)
            {
                throw new NullReferenceException("Null node cannot be passed");
            }

            ListItem<T> newNode = new ListItem<T>(value);

            if (searchNode == this.firstElement)
            {
                newNode.NextItem = searchNode;
                this.firstElement = newNode;
                count++;
                return;
            }

            ListItem<T> currentElement = this.firstElement;

            while (currentElement != this.lastElement)
            {
                if (currentElement.NextItem == searchNode)
                {
                    newNode.NextItem = searchNode;
                    currentElement.NextItem = newNode;
                    count++;
                    return;
                }
                currentElement = currentElement.NextItem;
            }
        }

        public void AddAfter(ListItem<T> searchNode, T value)
        {
            if (searchNode == null)
            {
                throw new NullReferenceException("Null node cannot be passed");
            }

            ListItem<T> newNode = new ListItem<T>(value);

            if (searchNode == this.lastElement)
            {
                newNode.NextItem = searchNode.NextItem;
                searchNode.NextItem = newNode;
                this.lastElement = newNode;
                count++;
                return;
            }

            ListItem<T> currentElement = this.firstElement;

            while (currentElement != this.lastElement)
            {
                if (currentElement == searchNode)
                {
                    newNode.NextItem = currentElement.NextItem;
                    currentElement.NextItem = newNode;
                    count++;
                    return;
                }
                currentElement = currentElement.NextItem;
            }
        }

        public void Remove(T value)
        {
            if (firstElement.Value.Equals(value))
            {
                this.firstElement = firstElement.NextItem;
                count--;
                return;
            }

            ListItem<T> currentElement = firstElement;

            while (currentElement != null)
            {
                if (currentElement.NextItem != null &&
                    currentElement.NextItem.Value.Equals(value))
                {
                    currentElement.NextItem = currentElement.NextItem.NextItem;
                    if (currentElement.NextItem == null)
                    {
                        this.lastElement = currentElement;
                    }
                    count--;
                    return;
                }
                currentElement = currentElement.NextItem;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            ListItem<T> currentElement = this.firstElement;
            while (currentElement != this.lastElement)
            {
                yield return currentElement.Value;
                currentElement = currentElement.NextItem;
            }
            yield return currentElement.Value;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
