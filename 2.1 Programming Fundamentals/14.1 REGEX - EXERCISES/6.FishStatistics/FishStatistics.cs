using System;
using System.Text.RegularExpressions;

namespace _6.FishStatistics
{
    public class FishStatistics
    {
        public static void Main()
        {
            var pattern = @"(>*)<(\(+)(['\-x])>";
            var fishMatch = new Regex(pattern);

            var inputLine = Console.ReadLine();

            if (fishMatch.IsMatch(inputLine))
            {
                var matchedFish = fishMatch.Matches(inputLine);

                var fishIndex = 1;
                foreach (Match fish in matchedFish)
                {
                    PrintFishData(fish, ref fishIndex);
                }
            }
            else
            {
                Console.WriteLine("No fish found.");
            }
        }

        private static void PrintFishData(Match fish, ref int fishIndex)
        {
            var fishShape = fish.Groups[0].Value;
            var fishTail = fish.Groups[1].Value;
            var fishBody = fish.Groups[2].Value;
            var fishStatus = fish.Groups[3].Value;

            var tailLength = fishTail.Length;
            var bodyLength = fishBody.Length;

            var tailType = GetTailType(tailLength);
            var bodyType = GetBodyType(bodyLength);
            var status = GetStatus(fishStatus);

            Console.WriteLine($"Fish {fishIndex}: {fishShape}");
            if (tailType == "None")
            {
                Console.WriteLine($"  Tail type: {tailType}");
            }
            else
            {
                Console.WriteLine($"  Tail type: {tailType} ({tailLength * 2} cm)");
            }
            Console.WriteLine($"  Body type: {bodyType} ({bodyLength * 2} cm)");
            Console.WriteLine($"  Status: {status}");

            fishIndex++;
        }

        private static string GetStatus(string fishStatus)
        {
            var status = string.Empty;

            switch (fishStatus)
            {
                case "'":
                    status = "Awake";
                    break;
                case "-":
                    status = "Asleep";
                    break;
                case "x":
                    status = "Dead";
                    break;
            }

            return status;
        }

        private static string GetBodyType(int bodyLength)
        {
            var bodyType = string.Empty;

            if (bodyLength > 10)
            {
                bodyType = "Long";
            }
            else if (bodyLength > 5)
            {
                bodyType = "Medium";
            }
            else
            {
                bodyType = "Short";
            }

            return bodyType;
        }

        private static string GetTailType(int tailLength)
        {
            var tailType = string.Empty;

            if (tailLength > 5)
            {
                tailType = "Long";
            }
            else if (tailLength > 1)
            {
                tailType = "Medium";
            }
            else if (tailLength > 0)
            {
                tailType = "Short";
            }
            else
            {
                tailType = "None";
            }

            return tailType;
        }
    }
}
