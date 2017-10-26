﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.HandsOfCards
{
    public class HandsOfCards
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var houseOfCards = new Dictionary<string, Dictionary<int, HashSet<int>>>();

            while (!input.Equals("JOKER"))
            {
                var handInfo = input.Split(new[] { ':', ','}, StringSplitOptions.RemoveEmptyEntries);
                var name = handInfo[0];

                if (!houseOfCards.ContainsKey(name))
                {
                    houseOfCards.Add(name, new Dictionary<int, HashSet<int>>());

                    for (int i = 1; i <= 4; i++)
                    {
                        houseOfCards[name].Add(i, new HashSet<int>());
                    }
                }

                for (int i = 1; i < handInfo.Length; i++)
                {
                    var currentCard = handInfo[i].Trim();

                    var face = 0;
                    var suite = 0;
                    if (currentCard.Length > 2)
                    {
                        face = GetFace(currentCard.Substring(0, 2));
                        suite = GetSuite(currentCard.Substring(2));
                    }
                    else
                    {
                        face = GetFace(currentCard[0].ToString());
                        suite = GetSuite(currentCard[1].ToString());
                    }

                    if (!houseOfCards[name][suite].Contains(face))
                    {
                        houseOfCards[name][suite].Add(face);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var outerKvp in houseOfCards)
            {
                var sum = 0;
                foreach (var innerKvp in outerKvp.Value)
                {
                    sum += innerKvp.Key * innerKvp.Value.Sum();
                }

                var name = outerKvp.Key;

                Console.WriteLine($"{name}: {sum}");
            }
        }

        private static int GetSuite(string suite)
        {
            switch (suite)
            {
                case "S":
                    return 4;

                case "H":
                    return 3;

                case "D":
                    return 2;

                case "C":
                    return 1;

                default:
                    return 0;
            }
        }

        private static int GetFace(string face)
        {
            switch (face)
            {
                case "J":
                    return 11;

                case "Q":
                    return 12;

                case "K":
                    return 13;

                case "A":
                    return 14;

                default:
                    return int.Parse(face);
            }
        }
    }
}
