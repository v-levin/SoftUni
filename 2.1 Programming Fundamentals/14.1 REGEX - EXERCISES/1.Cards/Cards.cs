using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1.Cards
{
    public class Cards
    {
        public static void Main()
        {
            var validCards = new List<string>();

            var regex = @"(?<=[A-Z]|)([0-9JQKA]+|10)[SDHC]";

            var cards = Console.ReadLine();

            var matchedCards = Regex.Matches(cards, regex);

            foreach (Match card in matchedCards)
            {
                var power = 0;

                if (int.TryParse(card.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }

                validCards.Add(card.Value);
            }

            Console.WriteLine(string.Join(", ", validCards));
        }
    }
}
