using System;
using System.Linq;

namespace _5.MinEvenNumber
{
    public class MinEvenNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .Where(n => n % 2 == 0)
                .ToList();

            if (numbers.Any())
            {
                var minNumber = numbers.Min();

                Console.WriteLine($"{minNumber:F2}");
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
