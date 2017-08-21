using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var result = new List<double>();

            GetResult(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void GetResult(List<double> numbers)
        {

            for (int i = 1; i < numbers.Count; i++)
            {
                var prevNumber = numbers[i - 1];
                var nextNumber = numbers[i];

                if (prevNumber == nextNumber)
                {
                    numbers[i - 1] = prevNumber + nextNumber;
                    numbers.Remove(numbers[i]);
                    GetResult(numbers);
                }
            }
        }
    }
}
