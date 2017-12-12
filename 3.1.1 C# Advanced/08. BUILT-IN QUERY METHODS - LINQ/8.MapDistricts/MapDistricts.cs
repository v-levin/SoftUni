using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.MapDistricts
{
    public class MapDistricts
    {
        public static void Main()
        {
            var population = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var minPopulation = long.Parse(Console.ReadLine());

            var districtsMap = new Dictionary<string, List<long>>();

            foreach (var district in population)
            {
                var tokens = district.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                var city = tokens[0];
                var districtPopulation = long.Parse(tokens[1]);

                if (!districtsMap.ContainsKey(city))
                {
                    districtsMap.Add(city, new List<long>());
                }

                districtsMap[city].Add(districtPopulation);
            }

            districtsMap = districtsMap
                .Where(p => p.Value.Sum() >= minPopulation)
                .OrderByDescending(p => p.Value.Sum())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var district in districtsMap)
            {
                Console.WriteLine($"{district.Key}: {string.Join(" ", district.Value.OrderByDescending(p => p).Take(5))}");
            }
            
        }
    }
}
