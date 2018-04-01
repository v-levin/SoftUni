﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private const int InitialCpacity = 10;
        private T[] elements;

        public Stack()
        {
            this.elements = new T[InitialCpacity];
        }

        public int Count { get; set; }

        public int Capacity { get => this.elements.Length; }

        public void Push(T element)
        {
            if (this.Count == this.Capacity)
            {
                this.Resize();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T tempElement = this.elements[this.Count - 1];
            this.Count--;
            return tempElement;
        }

        private void Resize()
        {
            Array.Resize(ref this.elements, 2 * this.Count);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
