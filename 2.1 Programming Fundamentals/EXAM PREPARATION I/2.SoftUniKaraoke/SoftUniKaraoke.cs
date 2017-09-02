using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SoftUniKaraoke
{
    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var awards = new Dictionary<string, HashSet<string>>();

            var participants = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var availableSongs = Console.ReadLine().Split(',').Select(s => s.Trim()).ToArray();

            var inputLine = Console.ReadLine();

            while (inputLine != "dawn")
            {
                var inputParams = inputLine.Split(',').Select(p => p.Trim()).ToArray();
                var participant = inputParams[0];
                var song = inputParams[1];
                var award = inputParams[2];

                if (participants.Contains(participant) && availableSongs.Contains(song))
                {
                    if (!awards.ContainsKey(participant))
                    {
                        awards[participant] = new HashSet<string>();
                    }

                    awards[participant].Add(award);
                }

                inputLine = Console.ReadLine();
            }

            if (awards.Count() > 0)
            {
                foreach (var award in awards.OrderByDescending(a => a.Value.Count()).ThenBy(p => p.Key))
                {
                    var participant = award.Key;
                    var awardsEarned = award.Value;
                    var numberOfAwards = award.Value.Count();

                    Console.WriteLine($"{participant}: {numberOfAwards} awards");

                    foreach (var awardEarned in awardsEarned.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{awardEarned}");
                    }

                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
