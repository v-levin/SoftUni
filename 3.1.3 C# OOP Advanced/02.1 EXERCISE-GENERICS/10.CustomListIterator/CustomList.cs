﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomListIterator
{
    public class CustomList<T> : ICustomList<T>, IEnumerable<T>
        where T : IComparable<T>
    {
        private readonly IList<T> elements;

        public CustomList() : this(Enumerable.Empty<T>())
        {
        }

        public CustomList(IEnumerable<T> collection) 
        {
            this.elements = new List<T>(collection);
        }

        public IList<T> Elements { get => this.elements; }

        public void Add(T element) => this.elements.Add(element);

        public T Remove(int index)
        {
            T temp = this.elements[index];
            this.elements.RemoveAt(index);

            return temp;
        }

        public bool Contains(T element) => this.elements.Contains(element);

        public void Swap(int index1, int index2)
        {
            var temp = this.elements[index1];
            this.elements[index1] = this.elements[index2];
            this.elements[index2] = temp;
        }

        public int CountGreaterThan(T element) => this.elements.Count(e => e.CompareTo(element) > 0);

        public T Max() => this.elements.Max();

        public T Min() => this.elements.Min();

        public IEnumerator<T> GetEnumerator()
        {
            return this.elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
