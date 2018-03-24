using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomList
{
    public class CustomList<T> : ICustomList<T>
        where T : IComparable<T>
    {
        private IList<T> list;

        public CustomList()
        {
            this.list = new List<T>();
        }

        public void Add(T element) => this.list.Add(element);

        public T Remove(int index)
        {
            T temp = this.list[index];
            this.list.RemoveAt(index);

            return temp;
        }

        public bool Contains(T element)
        {
            if (this.list.Contains(element))
            {
                return true;
            }

            return false;
        }

        public void Swap(int index1, int index2)
        {
            var temp = this.list[index1];
            this.list[index1] = this.list[index2];
            this.list[index2] = temp;
        }

        public int CountGreaterThan(T element) => this.list.Count(e => e.CompareTo(element) > 0);

        public T Max() => this.list.Max();

        public T Min() => this.list.Min();

        public void Print()
        {
            foreach (var element in this.list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
