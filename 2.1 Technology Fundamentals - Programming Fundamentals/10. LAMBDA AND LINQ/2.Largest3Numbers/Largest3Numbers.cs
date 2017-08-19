using System;
using System.Linq;

namespace _2.Largest3Numbers
{
    public class Largest3Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var maxThreeNumbers = numbers
                .OrderByDescending(n => n)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", maxThreeNumbers));
        }
    }
}
