using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
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

        public double GetRating()
        {
            return Math.Round(this.players.Select(s => s.Stats.Values).Sum(s => s.Average()));
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            var containsPlayer = this.players.Any(p => p.Name == playerName);
            if (!containsPlayer)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team. ");
            }

            var player = this.players.Where(p => p.Name == playerName).First();
            this.players.Remove(player);
        }
    }
}
