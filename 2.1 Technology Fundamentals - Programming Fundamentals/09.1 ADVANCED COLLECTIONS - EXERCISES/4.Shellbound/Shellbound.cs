using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Shellbound
{
    class Shellbound
    {
        public static void Main()
        {
            var shellsInRegion = new Dictionary<string, HashSet<int>>();

            var input = Console.ReadLine();

            while (input != "Aggregate")
            {
                var tokens = input.Split();
                var city = tokens[0];
                var value = int.Parse(tokens[1]);

                if (!shellsInRegion.ContainsKey(city))
                {
                    shellsInRegion[city] = new HashSet<int>();
                }

                shellsInRegion[city].Add(value);

                input = Console.ReadLine();
            }

            foreach (var region in shellsInRegion)
            {
                var city = region.Key;
                var value = region.Value;
                var giantShell = value.Sum() - (value.Sum() / value.Count);

                Console.WriteLine($"{city} -> {string.Join(", ", value)} ({giantShell})");
            }
        }
    }
}
