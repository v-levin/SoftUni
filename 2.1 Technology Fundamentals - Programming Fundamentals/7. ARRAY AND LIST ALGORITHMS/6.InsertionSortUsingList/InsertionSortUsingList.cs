using System;
using System.Linq;

namespace _6.InsertionSortUsingList
{
    class InsertionSortUsingList
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                var indexToCheck = i + 1;

                while (indexToCheck > 0)
                {
                    if (numbers[indexToCheck] < numbers[indexToCheck - 1])
                    {
                        var temp = numbers[indexToCheck];
                        numbers.Remove(numbers[indexToCheck]);
                        numbers.Insert(indexToCheck - 1, temp);
                    }

                    indexToCheck--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
