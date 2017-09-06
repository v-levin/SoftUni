using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.RageQuit
{
    public class RageQuit
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().ToUpper();

            var regex = new Regex(@"(\D+)(\d+)");

            var matches = regex.Matches(inputLine);

            var result = new StringBuilder();

            foreach (Match match in matches)
            {
                var symbols = match.Groups[1].Value;
                var times = int.Parse(match.Groups[2].Value);

                result.Append(Repeat(symbols, times));
            }

            var count = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(result);
        }

        private static string Repeat(string symbols, int times)
        {
            var result = new StringBuilder();

            for (int i = 0; i < times; i++)
            {
                result.Append(symbols);
            }

            return result.ToString();
        }
    }
}
