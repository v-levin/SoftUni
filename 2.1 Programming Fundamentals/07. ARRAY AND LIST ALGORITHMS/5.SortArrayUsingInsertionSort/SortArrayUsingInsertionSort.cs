using System;
using System.Linq;

namespace _5.SortArrayUsingInsertionSort
{
    class SortArrayUsingInsertionSort
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                var indexToCheck = i + 1;

                while (indexToCheck > 0)
                {
                    if (numbers[indexToCheck] < numbers[indexToCheck - 1])
                    {
                        var temp = numbers[indexToCheck];
                        numbers[indexToCheck] = numbers[indexToCheck - 1];
                        numbers[indexToCheck - 1] = temp;
                    }

                    indexToCheck--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
