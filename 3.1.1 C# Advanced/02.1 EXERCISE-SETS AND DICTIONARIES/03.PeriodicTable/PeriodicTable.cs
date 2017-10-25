using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    public class PeriodicTable
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var periodicTable = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine().Split();

                foreach (var element in elements)
                {
                    periodicTable.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", periodicTable));
        }
    }
}
