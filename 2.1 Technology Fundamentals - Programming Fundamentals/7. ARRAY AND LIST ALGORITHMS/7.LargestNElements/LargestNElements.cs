using System;
using System.Linq;

namespace _7.LargestNElements
{
    class LargestNElements
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var numberOfLargestElements = int.Parse(Console.ReadLine());

            numbers.Sort();
            numbers.Reverse();

            var result = numbers.Take(numberOfLargestElements);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
