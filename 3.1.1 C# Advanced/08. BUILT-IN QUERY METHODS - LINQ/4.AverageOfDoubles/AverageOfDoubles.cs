using System;
using System.Linq;

namespace _4.AverageOfDoubles
{
    public class AverageOfDoubles
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            var average = numbers.Average();

            Console.WriteLine($"{average:F2}");
        }
    }
}
