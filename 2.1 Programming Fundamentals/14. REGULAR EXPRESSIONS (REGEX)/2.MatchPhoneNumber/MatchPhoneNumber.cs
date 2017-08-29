using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.MatchPhoneNumber
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var regex = @"\+359(\s|-)2\1\d{3}\1\d{4}\b";

            var phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, regex);

            var matchedPhones = phoneMatches.Cast<Match>().Select(p => p.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
