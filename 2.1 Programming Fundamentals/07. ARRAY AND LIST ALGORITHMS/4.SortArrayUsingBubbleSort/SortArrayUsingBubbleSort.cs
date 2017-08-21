using System;
using System.Linq;

namespace _4.SortArrayUsingBubbleSort
{
    class SortArrayUsingBubbleSort
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var swapped = false;

            do
            {
                swapped = false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    var currentNumber = numbers[i];
                    var nextNumber = numbers[i + 1];

                    if (currentNumber > nextNumber)
                    {
                        numbers[i] = nextNumber;
                        numbers[i + 1] = currentNumber;

                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
