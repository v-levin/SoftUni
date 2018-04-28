using System;

namespace CardToString__
{
    public class StartUp
    {
        public static void Main()
        {
            var cardRank = Console.ReadLine();
            var cardSuit = Console.ReadLine();

            Card card = new Card(cardRank, cardSuit);

            Console.WriteLine(card);
        }
    }
}
