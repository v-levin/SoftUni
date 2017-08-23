using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.PointsCounter
{
    public class PointsCounter
    {
        public static void Main()
        {
            var playersData = new Dictionary<string, Dictionary<string, int>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "Result")
            {
                inputLine = RemoveProhibitedSymbols(inputLine);

                var inputParams = inputLine.Split('|');

                var score = int.Parse(inputParams[2]);
                var playerName = string.Empty;
                var team = string.Empty;

                if (IsTeamName(inputParams[0]))
                {
                    team = inputParams[0];
                    playerName = inputParams[1];
                }
                else
                {
                    playerName = inputParams[0];
                    team = inputParams[1];
                }

                if (!playersData.ContainsKey(team))
                {
                    playersData[team] = new Dictionary<string, int>();
                }

                playersData[team][playerName] = score;

                inputLine = Console.ReadLine();
            }

            foreach (var playerData in playersData.OrderByDescending(x => x.Value.Values.Sum()))
            {
                var team = playerData.Key;
                var totalPoints = playersData[team].Values.Sum();
                var bestPlayer = playersData[team].OrderByDescending(x => x.Value).First().Key;

                Console.WriteLine($"{team} => {totalPoints}");
                Console.WriteLine($"Most points scored by {bestPlayer}");
            }
        }

        private static bool IsTeamName(string name)
        {
            return name.All(c => Char.IsUpper(c));
        }

        private static string RemoveProhibitedSymbols(string inputLine)
        {
            var prohibitedSymbols = new string[] { "@", "%", "$", "*" };

            foreach (var prohibitedSymbol in prohibitedSymbols)
            {
                inputLine = inputLine.Replace(prohibitedSymbol, string.Empty);
            }

            return inputLine;
        }
    }
}
