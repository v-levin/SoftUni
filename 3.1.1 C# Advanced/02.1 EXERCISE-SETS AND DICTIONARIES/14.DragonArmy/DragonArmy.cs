using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.DragonArmy
{
    public class DragonArmy
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dragonArmy = new Dictionary<string, SortedDictionary<string, Dictionary<string, int>>>();

            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine().Split();
                var type = inputParams[0];
                var name = inputParams[1];

                var damage = 0;
                if (!int.TryParse(inputParams[2], out damage)) damage = 45;

                var health = 0;
                if (!int.TryParse(inputParams[3], out health)) health = 250;

                var armor = 0;
                if (!int.TryParse(inputParams[4], out armor)) armor = 10;

                if (!dragonArmy.ContainsKey(type))
                {
                    dragonArmy.Add(type, new SortedDictionary<string, Dictionary<string, int>>());
                }

                if (!dragonArmy[type].ContainsKey(name))
                {
                    dragonArmy[type].Add(name, new Dictionary<string, int>());
                }

                dragonArmy[type][name]["damage"] = damage;
                dragonArmy[type][name]["health"] = health;
                dragonArmy[type][name]["armor"] = armor;
            }

            PrintResult(dragonArmy);
        }

        private static void PrintResult(Dictionary<string, SortedDictionary<string, Dictionary<string, int>>> dragonArmy)
        {
            foreach (var dragon in dragonArmy)
            {
                var type = dragon.Key;
                var names = dragon.Value.Keys;

                var damageSum = 0;
                var healthSum = 0;
                var armorSum = 0;
                var dragonStats = new StringBuilder();
                foreach (var name in names)
                {
                    damageSum += dragonArmy[type][name]["damage"];
                    healthSum += dragonArmy[type][name]["health"];
                    armorSum += dragonArmy[type][name]["armor"];

                    dragonStats.Append(
                        $"-{name} -> " +
                        $"damage: {dragonArmy[type][name]["damage"]}, " +
                        $"health: {dragonArmy[type][name]["health"]}, " +
                        $"armor: {dragonArmy[type][name]["armor"]}" +
                        $"{Environment.NewLine}"
                        );
                }

                var averageDamage = (float)damageSum / dragonArmy[type].Count();
                var averageHealth = (float)healthSum / dragonArmy[type].Count();
                var averageArmor = (float)armorSum / dragonArmy[type].Count();

                Console.Write($"{type}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2}){Environment.NewLine}{dragonStats}");
            }
        }
    }
}
