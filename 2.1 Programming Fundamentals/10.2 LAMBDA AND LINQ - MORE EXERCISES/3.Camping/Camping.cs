using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Camping
{
    public class Camping
    {
        public static void Main()
        {
            var campingDict = new Dictionary<string, Dictionary<string, int>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split();
                var personName = inputParams[0];
                var camperModel = inputParams[1];
                var timeToStay = int.Parse(inputParams[2]);

                if (!campingDict.ContainsKey(personName))
                {
                    campingDict[personName] = new Dictionary<string, int>();
                    campingDict[personName][camperModel] = timeToStay;

                }
                else
                {
                    if (!campingDict[personName].ContainsKey(camperModel))
                    {
                        campingDict[personName][camperModel] = timeToStay;

                    }
                }
                
                inputLine = Console.ReadLine();
            }

            foreach (var data in campingDict.OrderByDescending(x => x.Value.Keys.Count).ThenBy(x => x.Key.Length))
            {
                var person = data.Key;
                var campersData = data.Value;
                var campersCount = campersData.Keys.Count;
                var timeToStaySum = campersData.Values.Sum();

                Console.WriteLine($"{person}: {campersCount}");

                campingDict[person].Select(x => "***" + x.Key).ToList().ForEach(Console.WriteLine);

                Console.WriteLine($"Total stay: {timeToStaySum} nights");
            }
        }
    }
}
