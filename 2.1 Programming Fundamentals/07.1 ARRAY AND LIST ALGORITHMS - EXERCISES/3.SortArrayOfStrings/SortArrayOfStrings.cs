using System;
using System.Linq;

namespace _3.SortArrayOfStrings
{
    class SortArrayOfStrings
    {
        static void Main()
        {
            var strings = Console.ReadLine()
                .Split()
                .ToArray();

            var swapped = false;

            do
            {
                swapped = false;

                for (int i = 1; i < strings.Length; i++)
                {
                    if (strings[i].CompareTo(strings[i - 1]) == -1)
                    {
                        var temp = strings[i - 1];
                        strings[i - 1] = strings[i];
                        strings[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
