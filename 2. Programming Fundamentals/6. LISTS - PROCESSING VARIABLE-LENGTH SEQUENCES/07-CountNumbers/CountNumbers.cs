using System;
using System.Linq;

namespace _07_CountNumbers
{
    class CountNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers.Sort();
            numbers.Add(int.MaxValue);  // adding max value so the else statement can be executed for the last number in the list

            var counter = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                var currentNumber = numbers[i];
                var nextNumber = numbers[i + 1];

                if (currentNumber == nextNumber)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{currentNumber} -> {counter}");
                    counter = 1;
                }

            }
        }
    }
}
