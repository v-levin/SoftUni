using System;
using System.Linq;

namespace _1_DistinctList
{
    class DistinctList
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];

                for (int j = i + 1; j < numbers.Count; j++)
                {
                    var nextNumber = numbers[j];

                    if (currentNumber == nextNumber)
                    {
                        numbers.RemoveAt(j);
                        j--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
