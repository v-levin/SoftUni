using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.CubicAssault
{
    public class CubicAssault
    {
        public static int ConvertThreshold = 1_000_000;

        public static void Main()
        {
            var regionSoldiers = new Dictionary<string, Dictionary<string, long>>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Count em all")
            {
                var tokens = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var regionName = tokens[0];
                var meteorType = tokens[1];
                var soldiersCount = int.Parse(tokens[2]);

                if (!regionSoldiers.ContainsKey(regionName))
                {
                    regionSoldiers.Add(regionName, new Dictionary<string, long>() { { "Green", 0 }, { "Red", 0 }, { "Black", 0 } });
                }

                regionSoldiers[regionName][meteorType] += soldiersCount;

                if (regionSoldiers[regionName]["Green"] >= ConvertThreshold)
                {
                    regionSoldiers[regionName]["Red"] += regionSoldiers[regionName]["Green"] / ConvertThreshold;
                    regionSoldiers[regionName]["Green"] %= ConvertThreshold;
                }

                if (regionSoldiers[regionName]["Red"] >= ConvertThreshold)
                {
                    regionSoldiers[regionName]["Black"] += regionSoldiers[regionName]["Red"] / ConvertThreshold;
                    regionSoldiers[regionName]["Red"] %= ConvertThreshold;
                }
            }

            var sortedRegions = regionSoldiers
                .OrderByDescending(m => m.Value["Black"])
                .ThenBy(r => r.Key.Length)
                .ThenBy(r => r.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var region in sortedRegions)
            {
                Console.WriteLine(region.Key);

                foreach (var innerData in region.Value.OrderByDescending(s => s.Value).ThenBy(m => m.Key))
                {
                    Console.WriteLine($"-> {innerData.Key} : {innerData.Value}");
                }
            }
        }
    }
}
