using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        public static void Main()
        {
            var teams = new List<Team>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                var inputParams = inputLine.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var command = inputParams[0];

                switch (command)
                {
                    case "Team":
                        var name = inputParams[1];
                        teams.Add(new Team(name));
                        break;

                    case "Add":
                        var teamName = inputParams[1];
                        var playerName = inputParams[2];
                        var stats = inputParams.Skip(3).Select(int.Parse).ToArray();
                        var teamExist = teams.Any(t => t.Name == teamName);
                        Team team;

                        if (!teamExist)
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            try
                            {
                                team = teams.Where(t => t.Name == teamName).First();
                                var player = new Player(playerName, stats);
                                team.AddPlayer(player);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;

                    case "Remove":
                        teamName = inputParams[1];
                        team = teams.Where(t => t.Name == teamName).First();
                        playerName = inputParams[2];
                        try
                        {
                            team.RemovePlayer(playerName);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case "Rating":
                        teamName = inputParams[1];
                        teamExist = teams.Any(t => t.Name == teamName);
                        if (!teamExist)
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            team = teams.Where(t => t.Name == teamName).First();
                            Console.WriteLine($"{teamName} - {team.GetRating()}");
                        }
                        break;
                }
            }
        }
    }
}
