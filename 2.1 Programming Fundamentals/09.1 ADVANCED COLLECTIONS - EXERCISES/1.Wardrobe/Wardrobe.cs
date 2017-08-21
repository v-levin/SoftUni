using System;
using System.Collections.Generic;

namespace _1.Wardrobe
{
    class Wardrobe
    {
        public static void Main()
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var color = tokens[0];
                var clothes = tokens[tokens.Length - 1].Split(',');

                AddClothes(wardrobe, color, clothes);
            }

            var searchClothes = Console.ReadLine().Split();
            var colorClothes = searchClothes[0];
            var item = searchClothes[1];

            PrintResult(wardrobe, colorClothes, item);
        }

        static void PrintResult(Dictionary<string, Dictionary<string, int>> wardrobe, string colorClothes, string item)
        {
            foreach (var color in wardrobe)
            {
                var clothesColor = color.Key;
                var itemsAndCount = color.Value;

                Console.WriteLine($"{clothesColor} clothes:");

                foreach (var itemPiece in itemsAndCount)
                {
                    var itemInWardrobe = itemPiece.Key;
                    var itemCount = itemPiece.Value;

                    if (clothesColor == colorClothes && itemInWardrobe == item)
                    {
                        Console.WriteLine($"* {itemInWardrobe} - {itemCount} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {itemInWardrobe} - {itemCount}");
                    }
                }
            }
        }

        static void AddClothes(Dictionary<string, Dictionary<string, int>> wardrobe, string color, string[] clothes)
        {
            if (!wardrobe.ContainsKey(color))
            {
                wardrobe[color] = new Dictionary<string, int>();
            }

            foreach (var item in clothes)
            {
                if (!wardrobe[color].ContainsKey(item))
                {
                    wardrobe[color][item] = 0;
                }

                wardrobe[color][item]++;
            }
        }
    }
}
