using System;
using System.Collections.Generic;

namespace ListyIterator
{
    public class ListyIterator<T>
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
    }
}
