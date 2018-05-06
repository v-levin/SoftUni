using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    public class StartUp
    {
        private static string firstPlayer;
        private static string secondPlayer;
        private static string winner;
        private static Card biggestCard;

        public static void Main()
        {
            firstPlayer = Console.ReadLine();
            secondPlayer = Console.ReadLine();

            List<Card> deck = GenerateDeck();
            List<Card> firstPlayerHand = new List<Card>();
            List<Card> secondPlayerHand = new List<Card>();

            while (firstPlayerHand.Count < 5 || secondPlayerHand.Count < 5)
            {
                var inputArgs = Console.ReadLine().Split();
                var rank = inputArgs[0];
                var suit = inputArgs[inputArgs.Length - 1];

                try
                {
                    Card card = new Card(rank, suit);

                    if (deck.Contains(card))
                    {
                        deck.Remove(card);

                        if (firstPlayerHand.Count < 5)
                        {
                            firstPlayerHand.Add(card);
                        }
                        else
                        {
                            secondPlayerHand.Add(card);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("No such card exists.");
                }
            }

            WinnerCheck(firstPlayerHand, secondPlayerHand);

            Console.WriteLine($"{winner} wins with {biggestCard.Name}.");
        }

        private static void WinnerCheck(List<Card> firstPlayerHand, List<Card> secondPlayerHand)
        {
            var firstPlayerMaxCard = firstPlayerHand.Max(c => c.Power);
            var secondPlayerMaxCard = secondPlayerHand.Max(c => c.Power);

            if (firstPlayerMaxCard > secondPlayerMaxCard)
            {
                winner = firstPlayer;
                biggestCard = firstPlayerHand.Where(c => c.Power == firstPlayerMaxCard).First();
            }
            else
            {
                winner = secondPlayer;
                biggestCard = secondPlayerHand.Where(c => c.Power == secondPlayerMaxCard).First();
            }
        }

        private static List<Card> GenerateDeck()
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

            return deck;
        }
    }
}
