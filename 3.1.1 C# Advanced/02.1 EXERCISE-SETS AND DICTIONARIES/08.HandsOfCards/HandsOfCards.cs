using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.HandsOfCards
{
    public class HandsOfCards
    {
        public static void Main()
        {
            var handout = Console.ReadLine();
            var handsOfCards = new Dictionary<string, HashSet<string>>();

            while (!handout.Equals("JOKER"))
            {
                var handoutTokens = handout.Split(':');
                var playerName = handoutTokens[0];
                var cards = handoutTokens[1].Split(',').Select(c => c.Trim()).ToArray();

                if (!handsOfCards.ContainsKey(playerName))
                {
                    handsOfCards.Add(playerName, new HashSet<string>());
                }

                handsOfCards[playerName].UnionWith(cards);

                handout = Console.ReadLine();
            }

            PrintPlayersAndScores(handsOfCards);
        }

        private static void PrintPlayersAndScores(Dictionary<string, HashSet<string>> handsOfCards)
        {
            foreach (var player in handsOfCards)
            {
                var playerName = player.Key;
                var cards = player.Value;
                var score = CalculateScore(cards);

                Console.WriteLine($"{playerName}: {score}");
            }
        }

        private static int CalculateScore(HashSet<string> cards)
        {
            var score = 0;

            foreach (var card in cards)
            {
                var type = card.Last().ToString();
                var power = card.Substring(0, card.Length - 1);

                score += GetType(type) * GetPower(power);
            }

            return score;
        }

        private static int GetType(string type)
        {
            switch (type)
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

        private static int GetPower(string power)
        {
            switch (power)
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
                    return int.Parse(power);
            }
        }
    }
}
