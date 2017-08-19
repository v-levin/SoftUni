using System;
using System.Collections.Generic;

namespace _3.TravelCompany
{
    class TravelCompany
    {
        public static void Main()
        {
            var citiesTransportType = new Dictionary<string, Dictionary<string, int>>();

            var inputLine = Console.ReadLine();

            GetTransportData(citiesTransportType, inputLine);

            inputLine = Console.ReadLine();

            GetAccommodation(citiesTransportType, inputLine);
        }

        static void GetAccommodation(Dictionary<string, Dictionary<string, int>> citiesTransportType, string inputLine)
        {
            while (inputLine != "travel time!")
            {
                var tokens = inputLine.Split();
                var city = tokens[0];
                var peopleCount = int.Parse(tokens[1]);

                var transportCapacities = GetTransportCapacities(citiesTransportType, city);

                if (peopleCount <= transportCapacities)
                {
                    Console.WriteLine($"{city} -> all {peopleCount} accommodated");
                }
                else
                {
                    Console.WriteLine($"{city} -> all except {peopleCount - transportCapacities} accommodated");
                }

                inputLine = Console.ReadLine();
            }
        }

        static int GetTransportCapacities(Dictionary<string, Dictionary<string, int>> citiesTransportType, string city)
        {
            var sum = 0;

            foreach (var capacityCount in citiesTransportType[city])
            {
                var capacity = capacityCount.Value;

                sum += capacity;
            }

            return sum;
        }

        static void GetTransportData(Dictionary<string, Dictionary<string, int>> citiesTransportType, string inputLine)
        {
            while (inputLine != "ready")
            {
                var tokens = inputLine.Split(':');
                var city = tokens[0];
                var transportData = tokens[1].Split(',');

                if (!citiesTransportType.ContainsKey(city))
                {
                    citiesTransportType[city] = new Dictionary<string, int>();
                }

                foreach (var transportAndCapacity in transportData)
                {
                    var tokensData = transportAndCapacity.Split('-');
                    var transportType = tokensData[0];
                    var capacity = int.Parse(tokensData[1]);

                    if (!citiesTransportType[city].ContainsKey(transportType))
                    {
                        citiesTransportType[city][transportType] = 0;
                    }

                    citiesTransportType[city][transportType] = capacity;
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
