using System;

namespace CardCompareTo__
{
    public class StartUp
    {
        public static void Main()
        {
            Card firstCard = ReadCard();
            Card secondCard = ReadCard();

            if (firstCard.CompareTo(secondCard) > 0)
            {
                Console.WriteLine(firstCard);
            }
            else
            {
                Console.WriteLine(secondCard);
            }
        }

        public static Card ReadCard()
        {
            var cardRank = Console.ReadLine();
            var cardSuit = Console.ReadLine();

            Card card = new Card(cardRank, cardSuit);

            return card;
        }
    }
}
