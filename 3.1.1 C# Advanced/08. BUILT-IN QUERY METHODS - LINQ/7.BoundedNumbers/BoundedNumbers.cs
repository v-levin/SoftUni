using System;
using System.Linq;

namespace _7.BoundedNumbers
{
    public class BoundedNumbers
    {
        public static void Main()
        {
            var boundaries = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var minBound = boundaries.Min();
            var maxBound = boundaries.Max();

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => n >= minBound && n <= maxBound)
                .ToList();

            numbers.ForEach(n => Console.Write(n + " "));
        }
    }
}
