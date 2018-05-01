using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class StartUp
    {
        public static void Main()
        {
            List<Card> deck = new List<Card>();

            foreach (var suit in Enum.GetNames(typeof(Suit)))
            {
                foreach (var rank in Enum.GetNames(typeof(Rank)))
                {
                    Card card = new Card(rank, suit);
                    deck.Add(card);
                }
            }

            foreach (var card in deck)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}
