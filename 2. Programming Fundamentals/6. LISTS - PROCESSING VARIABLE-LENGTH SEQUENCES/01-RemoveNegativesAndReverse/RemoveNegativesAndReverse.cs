using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();
            
            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    result.Add(number);
                }
            }

            result.Reverse();

            if (!result.Any())
            {
                Console.Write("empty");
            }
            else
            {
                foreach (var number in result)
                {
                    Console.Write($"{number} ");
                }
            }

            Console.WriteLine();
        }
    }
}
