using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListTraversal
{
    public class CustomLinkedList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        public class Node
        {
            public Node(T value)
            {
                this.Value = value;
            }

            public T Value { get; set; }
            public Node Next { get; set; }            
        }

        public Node Head { get; private set; }
        public Node Tail { get; private set; }
        public int Count { get; private set; }

        public void Add(T item)
        {
            Node old = this.Tail;
            this.Tail = new Node(item);

            if (IsEmpty())
            {
                this.Head = this.Tail;
            }
            else
            {
                old.Next = this.Tail;
            }

            this.Count++;
        }

        public void Remove(T item)
        {
            if (IsEmpty())
            {
                return;
            }

            if (this.Head.Value.CompareTo(item) == 0)
            {
                this.Head = this.Head.Next;
                this.Count--;
                return;
            }

            Node previous = this.Head;
            Node current = this.Head.Next;

            while (current != null)
            {
                if (current.Value.CompareTo(item) == 0)
                {
                    previous.Next = current.Next;
                    this.Count--;
                    return;
                }

                previous = current;
                current = current.Next;
            }
        }

        private bool IsEmpty()
        {
            return (this.Count == 0) ? true : false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = this.Head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
