using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.CountRealNumbers
{
    class CountRealNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var result = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!result.ContainsKey(number))
                {
                    result[number] = 0;
                }

                result[number]++;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
