using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.CottageScraper
{
    public class CottageScraper
    {
        public static void Main()
        {
            var cottageScraperDict = new Dictionary<string, List<int>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "chop chop")
            {
                var inputParams = inputLine.Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var treeType = inputParams[0];
                var treeLength = int.Parse(inputParams[1]);

                if (!cottageScraperDict.ContainsKey(treeType))
                {
                    cottageScraperDict[treeType] = new List<int>();
                }

                cottageScraperDict[treeType].Add(treeLength);

                inputLine = Console.ReadLine();
            }

            var typeOfTreeToBeUsed = Console.ReadLine();
            var minLengthPerTree = int.Parse(Console.ReadLine());
            
            var sumOfTreeLengths = 0;
            var countOfTreeLengths = 0;

            foreach (var treeType in cottageScraperDict.Keys)
            {
                sumOfTreeLengths += cottageScraperDict[treeType].Sum();
                countOfTreeLengths += cottageScraperDict[treeType].Count;
            }

            var pricePerMeter = Math.Round((decimal)sumOfTreeLengths / countOfTreeLengths, 2);   // to be printed

            var usedLogsSum = cottageScraperDict[typeOfTreeToBeUsed]
                .Where(x => x >= minLengthPerTree)
                .Sum();

            var usedLogsPrice = Math.Round(usedLogsSum * pricePerMeter, 2);   // to be printed
            
            var unusedLogs = new List<int>();

            foreach (var treeType in cottageScraperDict.Keys)
            {
                if (treeType != typeOfTreeToBeUsed)
                    unusedLogs.AddRange(cottageScraperDict[treeType]);
                else
                    unusedLogs.AddRange(cottageScraperDict[treeType].Where(x => x < minLengthPerTree));
            }

            var unusedLogsPrice = Math.Round(unusedLogs.Sum() * pricePerMeter * 0.25m, 2);   // to be printed

            var subtotal = usedLogsPrice + unusedLogsPrice;   // to be printed

            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:F2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:F2}");
            Console.WriteLine($"CottageScraper subtotal: ${subtotal:F2}");
        }
    }
}
