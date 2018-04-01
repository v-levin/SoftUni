using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private IList<T> elements;
        private int currentIndex;

        public ListyIterator(IEnumerable<T> elements)
        {
            this.elements = new List<T>(elements);
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this.currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.currentIndex < this.elements.Count - 1)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.elements.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            Console.WriteLine(this.elements[currentIndex]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
