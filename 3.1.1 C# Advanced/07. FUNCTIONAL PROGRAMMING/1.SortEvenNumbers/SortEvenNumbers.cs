using System;
using System.Linq;

namespace _1.SortEvenNumbers
{
    public class SortEvenNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine();

            var evenNumbers = numbers
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToList();

            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
