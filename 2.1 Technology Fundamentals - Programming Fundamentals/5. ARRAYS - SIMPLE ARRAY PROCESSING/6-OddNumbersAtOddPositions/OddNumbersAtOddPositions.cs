using System;
using System.Linq;

namespace _6_OddNumbersAtOddPositions
{
    class OddNumbersAtOddPositions
    {
        static void Main()
        {
            int[] arrOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            
            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                int currentNumber = arrOfNumbers[i];

                if (i % 2 != 0 && currentNumber % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {currentNumber}");
                }
            }
        }
    }
}
