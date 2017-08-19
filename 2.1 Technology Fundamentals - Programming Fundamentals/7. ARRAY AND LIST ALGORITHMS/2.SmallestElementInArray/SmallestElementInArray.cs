using System;
using System.Linq;

namespace _2.SmallestElementInArray
{
    class SmallestElementInArray
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var smallestNumber = int.MaxValue;

            foreach (var number in numbers)
            {
                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
            }

            Console.WriteLine(smallestNumber);
        }
    }
}
