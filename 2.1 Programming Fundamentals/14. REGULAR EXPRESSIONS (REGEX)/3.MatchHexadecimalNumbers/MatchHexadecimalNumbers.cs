using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.MatchHexadecimalNumbers
{
    public class MatchHexadecimalNumbers
    {
        public static void Main()
        {
            var regex = @"\b(?:0x)?[0-9A-F]+\b";

            var numbersString = Console.ReadLine();

            var numbers = Regex.Matches(numbersString, regex).Cast<Match>().Select(n => n.Value).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
