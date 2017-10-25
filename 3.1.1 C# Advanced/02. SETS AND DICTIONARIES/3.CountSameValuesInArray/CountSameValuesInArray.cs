using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.CountSameValuesInArray
{
    public class CountSameValuesInArray
    {
        public static void Main()
        {
            var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            var valueOccurances = new SortedDictionary<double, int>();

            foreach (var number in tokens)
            {
                if (!valueOccurances.ContainsKey(number))
                {
                    valueOccurances[number] = 1;
                    continue;
                }

                valueOccurances[number]++;
            }

            foreach (var kvp in valueOccurances)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
