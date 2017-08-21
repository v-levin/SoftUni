using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_EqualSumAfterExtraction
{
    class EqualSumAfterExtraction
    {
        static void Main()
        {
            var firstListOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondListOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < secondListOfNumbers.Count; i++)
            {
                var currentNumber = secondListOfNumbers[i];

                if (firstListOfNumbers.Contains(currentNumber))
                {
                    secondListOfNumbers.Remove(currentNumber);
                    i = -1;
                }
            }

            var firstListSum = 0;
            var secondListSum = 0;

            firstListSum = GetSum(firstListOfNumbers, firstListSum);
            secondListSum = GetSum(secondListOfNumbers, secondListSum);

            if (firstListSum == secondListSum)
            {
                Console.WriteLine($"Yes. Sum: {firstListSum}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(firstListSum - secondListSum)}");
            }
        }

        private static int GetSum(List<int> listOfNumbers, int sum)
        {
            foreach (var number in listOfNumbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
