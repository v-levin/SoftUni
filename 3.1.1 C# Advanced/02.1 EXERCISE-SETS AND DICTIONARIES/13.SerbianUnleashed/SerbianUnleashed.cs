using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _13.SerbianUnleashed
{
    public class SerbianUnleashed
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var venueData = new Dictionary<string, Dictionary<string, int>>();

            while (input != "End")
            {
                var regex = new Regex(@"(.+?)\s@(.+?)\s(\d+)\s(\d+)");
                var isMatched = regex.IsMatch(input);

                if (isMatched)
                {
                    var match = regex.Match(input);

                    var singer = match.Groups[1].ToString();
                    var venue = match.Groups[2].ToString();
                    var ticketsPrice = int.Parse(match.Groups[3].ToString());
                    var ticketsCount = int.Parse(match.Groups[4].ToString());

                    if (!venueData.ContainsKey(venue))
                    {
                        venueData.Add(venue, new Dictionary<string, int>());
                    }

                    if (!venueData[venue].ContainsKey(singer))
                    {
                        venueData[venue][singer] = 0;
                    }

                    venueData[venue][singer] += ticketsPrice * ticketsCount;
                }

                input = Console.ReadLine();
            }

            foreach (var venue in venueData)
            {
                Console.WriteLine(venue.Key);

                foreach (var singer in venue.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
