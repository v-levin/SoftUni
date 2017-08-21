﻿using System;
using System.Collections.Generic;

namespace _2.CitiesByContinentAndCountry
{
    class CitiesByContinentAndCountry
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var continentsData = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var continent = input[0];
                var country = input[1];
                var town = input[2];

                AddTown(continentsData, continent, country, town);
                
            }

            PrintResult(continentsData);
        }

        static void PrintResult(Dictionary<string, Dictionary<string, List<string>>> continentsData)
        {
            foreach (var continentCountries in continentsData)
            {
                var continentName = continentCountries.Key;
                var countries = continentCountries.Value;

                Console.WriteLine($"{continentName}:");

                foreach (var countryCities in countries)
                {
                    var countryName = countryCities.Key;
                    var towns = countryCities.Value;

                    Console.WriteLine($"  {countryName} -> {string.Join(", ", towns)}");
                }
            }
        }

        static void AddTown(Dictionary<string, Dictionary<string, List<string>>> continentsData, string continent, string country, string town)
        {
            if (!continentsData.ContainsKey(continent))
            {
                continentsData[continent] = new Dictionary<string, List<string>>();
            }

            if (!continentsData[continent].ContainsKey(country))
            {
                continentsData[continent][country] = new List<string>();
            }

            continentsData[continent][country].Add(town);
        }
    }
}
