using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            var integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var elementToSearch = int.Parse(Console.ReadLine());

            var countOfLinearIterations = 0;
            var countOfBinaryIterations = 0;
            bool yes = false;

            LinearSearchResult(integers, elementToSearch, ref countOfLinearIterations, ref yes);
            BinarySearchResult(integers, elementToSearch, ref countOfBinaryIterations);

            PrintResult(countOfLinearIterations, countOfBinaryIterations, yes);
        }

        static void BinarySearchResult(List<int> integers, int elementToSearch, ref int countOfBinaryIterations)
        {
            integers.Sort();

            var lowIndex = 0;
            var highIndex = integers.Count - 1;

            while (true)
            {
                if (highIndex < lowIndex) break;

                countOfBinaryIterations++;

                var midIndex = lowIndex + (highIndex - lowIndex) / 2;

                if (integers[midIndex] < elementToSearch) lowIndex = midIndex + 1;

                if (integers[midIndex] > elementToSearch) highIndex = midIndex - 1;

                if (integers[midIndex] == elementToSearch) break;
            }
        }

        static void PrintResult(int countOfLinearIterations, int countOfBinaryIterations, bool yes)
        {
            if (yes)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine($"Linear search made {countOfLinearIterations} iterations");
            Console.WriteLine($"Binary search made {countOfBinaryIterations} iterations");
        }

        static void LinearSearchResult(List<int> integers, int elementToSearch, ref int countOfIterations, ref bool yes)
        {
            for (int i = 0; i < integers.Count; i++)
            {
                var currentNumber = integers[i];

                if (currentNumber == elementToSearch)
                {
                    yes = true;
                    countOfIterations = i + 1;
                    break;
                }

                countOfIterations = i + 1;
            }
        }
    }
}
