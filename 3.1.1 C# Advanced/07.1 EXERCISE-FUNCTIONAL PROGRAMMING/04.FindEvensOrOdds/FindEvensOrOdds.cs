using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    public class FindEvensOrOdds
    {
        public static void Main()
        {
            var rangeBounds = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var lowerBound = rangeBounds[0];
            var upperBound = rangeBounds[1];
            var command = Console.ReadLine();

            var numbers = Enumerable.Range(lowerBound, upperBound - lowerBound + 1);
            Predicate<int> isEven = n => n % 2 == 0;

            PrintNumbers(numbers, command, isEven);
        }

        private static void PrintNumbers(IEnumerable<int> numbers, string command, Predicate<int> isEven)
        {
            var result = new List<int>();

            foreach (var number in numbers)
            {
                if (isEven(number) && command == "even")
                {
                    result.Add(number);
                }
                else if (!isEven(number) && command == "odd")
                {
                    result.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
