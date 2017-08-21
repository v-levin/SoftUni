using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.SoftUniBeerPong
{
    public class SoftUniBeerPong
    {
        public static void Main()
        {
            var beerPongDict = new Dictionary<string, Dictionary<string, int>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "stop the game")
            {
                var inputParams = inputLine.Split('|');
                var playerName = inputParams[0];
                var team = inputParams[1];
                var points = int.Parse(inputParams[2]);

                if (!beerPongDict.ContainsKey(team))
                {
                    beerPongDict[team] = new Dictionary<string, int>();
                }
                
                if (beerPongDict[team].Values.Count < 3)
                {
                    beerPongDict[team][playerName] = points;
                }

                inputLine = Console.ReadLine();
            }

            var counter = 1;

            foreach (var team in beerPongDict.Where(x => x.Value.Count == 3).OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{counter}. {team.Key}; Players:");

                beerPongDict[team.Key]
                    .OrderByDescending(x => x.Value)
                    .Select(x => "###" + x.Key + ": " + x.Value)
                    .ToList()
                    .ForEach(Console.WriteLine);

                counter++;
            }
        }
    }
}
