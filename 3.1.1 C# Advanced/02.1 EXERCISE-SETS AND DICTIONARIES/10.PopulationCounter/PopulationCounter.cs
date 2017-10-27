using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PopulationCounter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var populationReport = new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                var inputParams = input.Split('|');
                var city = inputParams[0];
                var country = inputParams[1];
                var population = int.Parse(inputParams[2]);

                if (!populationReport.ContainsKey(country))
                {
                    populationReport.Add(country, new Dictionary<string, long>());
                }

                populationReport[country].Add(city, population);
                
                input = Console.ReadLine();
            }

            foreach (var report in populationReport.OrderByDescending(r => r.Value.Values.Sum()))
            {
                var country = report.Key;
                var totalPopulation = report.Value.Values.Sum();

                Console.WriteLine($"{country} (total population: {totalPopulation})");
                Console.WriteLine($"{string.Join(Environment.NewLine, report.Value.OrderByDescending(r => r.Value).Select(r => $"=>{r.Key}: {r.Value}"))}");
            }
        }
    }
}
