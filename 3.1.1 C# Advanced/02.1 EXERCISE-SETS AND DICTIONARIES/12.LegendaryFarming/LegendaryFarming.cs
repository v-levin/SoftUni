using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.LegendaryFarming
{
    public class LegendaryFarming
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower();

            var legendaryItems = new Dictionary<string, int>
            {
                { "shards", 0 },
                { "fragments", 0 },
                { "motes", 0 }
            };

            var junkItems = new SortedDictionary<string, int>();

            var itemObtained = false;
            var legendaryItem = string.Empty;

            while (true)
            {
                var inputParams = input.Split();

                for (int i = 1; i < inputParams.Length; i += 2)
                {
                    var quantity = int.Parse(inputParams[i - 1]);
                    var material = inputParams[i];

                    if (legendaryItems.ContainsKey(material))
                    {
                        legendaryItems[material] += quantity;
                    }
                    else if (junkItems.ContainsKey(material))
                    {
                        junkItems[material] += quantity;
                        continue;
                    }
                    else
                    {
                        junkItems.Add(material, quantity);
                        continue;
                    }

                    if (legendaryItems[material] >= 250)
                    {
                        legendaryItems[material] -= 250;

                        legendaryItem = GetLegendaryItem(legendaryItem, material);

                        itemObtained = true;
                        break;
                    }
                }

                if (itemObtained)
                {
                    break;
                }

                input = Console.ReadLine().ToLower();
            }

            PrintResult(legendaryItems, junkItems, legendaryItem);
        }

        private static void PrintResult(Dictionary<string, int> legendaryItems, SortedDictionary<string, int> junkItems, string legendaryItem)
        {
            Console.WriteLine($"{legendaryItem} obtained!");

            foreach (var item in legendaryItems.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static string GetLegendaryItem(string legendaryItem, string material)
        {
            switch (material)
            {
                case "shards":
                    return "Shadowmourne";
                case "fragments":
                    return "Valanyr";
                case "motes":
                    return "Dragonwrath";
                default:
                    return "";
            }
        }
    }
}
