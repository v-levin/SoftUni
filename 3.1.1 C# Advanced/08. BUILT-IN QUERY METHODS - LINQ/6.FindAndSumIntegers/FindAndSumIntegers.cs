using System;
using System.Linq;

namespace _6.FindAndSumIntegers
{
    public class FindAndSumIntegers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Where(s => !s.All(char.IsLetter))
                .Select(long.Parse)
                .ToList();

            if (input.Any())
            {
                var sum = input.Sum();

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
