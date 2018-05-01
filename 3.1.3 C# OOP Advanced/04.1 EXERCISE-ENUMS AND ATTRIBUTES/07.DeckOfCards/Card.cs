﻿using System;

namespace DeckOfCards
{
    public class Card : IComparable<Card>
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

        public int CompareTo(Card other)
        {
            if (ReferenceEquals(this, other))
                return 0;
            if (ReferenceEquals(null, other))
                return 1;

            var rankComparison = this.Rank.CompareTo(other.Rank);

            if (rankComparison != 0)
            {
                return rankComparison;
            }

            return this.Suit.CompareTo(other.Suit);
        }

        public override string ToString()
        {
            return $"Card name: {this.Name}; Card power: {this.Power}";
        }
    }
}
