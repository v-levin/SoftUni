using System;
using System.Collections.Generic;

namespace _4.GroupContinentsCountriesAndCities
{
    class GroupContinentsCountriesAndCities
    {
        public static void Main()
        {
            var data = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currentData = Console.ReadLine().Split();
                var continent = currentData[0];
                var country = currentData[1];
                var city = currentData[2];

                AddData(data, continent, country, city);
            }

            PrintResult(data);
        }

        private static void PrintResult(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> data)
        {
            foreach (var continentName in data)
            {
                var continent = continentName.Key;
                var countries = continentName.Value;

                Console.WriteLine($"{continent}:");

                foreach (var country in countries)
                {
                    var countryName = country.Key;
                    var cities = country.Value;

                    Console.WriteLine($"  {countryName} -> {string.Join(", ", cities)}");
                }
            }
        }

        static void AddData(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> data, string continent, string country, string city)
        {
            if (!data.ContainsKey(continent))
            {
                data[continent] = new SortedDictionary<string, SortedSet<string>>();
            }

            if (!data[continent].ContainsKey(country))
            {
                data[continent][country] = new SortedSet<string>();
            }

            data[continent][country].Add(city);
        }
    }
}
