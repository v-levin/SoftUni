using System;
using System.Text.RegularExpressions;

namespace _1.MatchCount
{
    public class MatchCount
    {
        public static void Main()
        {
            var pattern = Console.ReadLine();
            var input = Console.ReadLine();

            var regex = new Regex(pattern);
            var matches = regex.Matches(input);

            Console.WriteLine(matches.Count);
        }
    }
}
