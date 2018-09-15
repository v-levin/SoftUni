using System;
using System.Collections.Generic;

namespace IteratorTest.Models
{
    public class ListIterator
    {
        private readonly List<string> collection;
        private int currentIndex;

        public ListIterator(IEnumerable<string> collection)
        {
            NullValidator(collection);
            this.collection = new List<string>(collection);
        }

        private void NullValidator(IEnumerable<string> collection)
        {
            if (collection is null)
                throw new ArgumentNullException();
        }

        public bool Move() => ++this.currentIndex < this.collection.Count;

        public bool HasNext() => this.currentIndex < this.collection.Count - 1;

        public string Print()
        {
            if (this.collection.Count == 0)
                throw new InvalidOperationException("Invalid Operation!");

            return this.collection[this.currentIndex];
        }
    }
}
