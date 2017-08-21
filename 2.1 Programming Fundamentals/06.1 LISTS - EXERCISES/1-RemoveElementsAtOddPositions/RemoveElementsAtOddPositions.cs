using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_RemoveElementsAtOddPositions
{
    class RemoveElementsAtOddPositions
    {
        static void Main()
        {
            var elements = Console.ReadLine()
                .Split(' ')
                .ToList();

            var result = new List<string>();

            for (int i = 1; i <= elements.Count; i++)
            {
                if (i % 2 == 0)
                {
                    result.Add(elements[i - 1]);
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
