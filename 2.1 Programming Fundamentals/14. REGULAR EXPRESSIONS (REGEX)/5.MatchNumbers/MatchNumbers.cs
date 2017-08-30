using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _5.MatchNumbers
{
    public class MatchNumbers
    {
        public static void Main()
        {
            var regex = @"(^|(?<=\s))-?\d+(?:\.\d+)?($|(?=\s))";

            var numberStrings = Console.ReadLine();

            var numbers = Regex.Matches(numberStrings, regex).Cast<Match>().Select(n => n.Value).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
