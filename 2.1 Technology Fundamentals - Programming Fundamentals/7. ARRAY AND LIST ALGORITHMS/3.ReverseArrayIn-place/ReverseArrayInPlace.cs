using System;
using System.Linq;

namespace _3.ReverseArrayIn_place
{
    class ReverseArrayInPlace
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                var firstIndex = i;
                var lastIndex = numbers.Length - 1 - i;

                var temp = numbers[firstIndex];
                numbers[firstIndex] = numbers[lastIndex];
                numbers[lastIndex] = temp;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
