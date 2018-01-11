using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private Dictionary<string, int> stats;

        public Player(string name, int[] stats)
        {
            this.Name = name;
            this.Stats = new Dictionary<string, int>()
            {
                { "Endurance", stats[0] },
                { "Sprint", stats[1] },
                { "Dribble", stats[2] },
                { "Passing", stats[3] },
                { "Shooting", stats[4] },
            };
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public Dictionary<string,int> Stats
        {
            get { return this.stats; }
            private set
            {
                if (value.Any(s => s.Value < 0 || s.Value > 100))
                {
                    var outOfRangeStat = value.Where(s => s.Value < 0 || s.Value > 100).Select(s => s.Key).First();
                    throw new ArgumentException($"{outOfRangeStat} should be between 0 and 100.");
                }

                this.stats = value;
            }
        }
    }
}
