using System;

namespace CardPower
{
    public class Card
    {
        public Card(string rank, string suit)
        {
            this.Rank = (Rank)Enum.Parse(typeof(Rank), rank);
            this.Suit = (Suit)Enum.Parse(typeof(Suit), suit);
        }   

        public Rank Rank { get; set; }

        public Suit Suit { get; set; }

        public int Power
        {
            get { return (int)this.Rank + (int)this.Suit; }
        }

        public string Name
        {
            get { return $"{this.Rank} of {this.Suit}"; }
        }

        public override string ToString()
        {
            return $"Card name: {this.Name}; Card power: {this.Power}";
        }
    }
}
