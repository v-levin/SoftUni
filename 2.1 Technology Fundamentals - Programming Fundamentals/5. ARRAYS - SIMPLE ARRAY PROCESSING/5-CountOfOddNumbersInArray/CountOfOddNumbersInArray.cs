using System;
using System.Linq;

namespace _5_CountOfOddNumbersInArray
{
    class CountOfOddNumbersInArray
    {
        static void Main(string[] args)
        {
            int[] arrOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int oddNumbersCount = 0;

            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                int currentNumber = arrOfNumbers[i];

                if (currentNumber % 2 != 0)
                {
                    oddNumbersCount++;
                }
            }

            Console.WriteLine(oddNumbersCount);
        }
    }
}
