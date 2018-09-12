using System;
using System.Linq;

namespace Database
{
    public class Database
    {
        private const int MaxCapacity = 16;
        private const string CapacityExeptionMessage = "The max capacity of the collection is {MaxCapacity}.";
        private const string EmptyCollectionExeptionMessage = "The collection is already empty.";

        private readonly int[] elements;
        private int currentIndex;

        public Database(params int[] elements)
        {
            this.elements = new int[MaxCapacity];
            this.currentIndex = 0;
            this.Elements = elements.ToArray();
        }

        public int Index => this.currentIndex;

        public int[] Elements
        {
            get => this.elements;
            set
            {
                if (value.Length > MaxCapacity)
                {
                    throw new InvalidOperationException(CapacityExeptionMessage);
                }

                foreach (var element in value)
                {
                    this.elements[this.currentIndex] = element;
                    this.currentIndex++;
                }
            }
        }

        public void Add(int element)
        {
            if (this.currentIndex >= MaxCapacity)
            {
                throw new InvalidOperationException(CapacityExeptionMessage);
            }

            this.elements[this.currentIndex] = element;
            this.currentIndex++;
        }

        public void Remove()
        {
            if (this.currentIndex == 0)
            {
                throw new InvalidOperationException(EmptyCollectionExeptionMessage);
            }

            this.elements[this.currentIndex - 1] = 0;
            this.currentIndex--;
        }

        public int[] Fetch()
        {
            return this.elements.Take(this.currentIndex).ToArray();
        }
    }
}
