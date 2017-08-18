using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_TearListInHalf
{
    class TearListInHalf
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var numbersCount = numbers.Count;
            var halfOfNumbers = numbers.Count / 2;
            var rightHalf = new List<int>();

            for (int i = halfOfNumbers; i < numbersCount; i++)
            {
                rightHalf.Add(numbers[i]);
            }

            var result = new List<int>();

            for (int i = 0; i < halfOfNumbers; i++)
            {
                result.Add(rightHalf[i] / 10);
                result.Add(numbers[i]);
                result.Add(rightHalf[i] % 10);
            }

            Console.WriteLine(string.Join(" ", result.Select(x => x.ToString())));
        }
    }
}
