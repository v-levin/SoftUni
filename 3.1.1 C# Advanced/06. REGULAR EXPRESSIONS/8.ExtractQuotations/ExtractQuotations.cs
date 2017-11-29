using System;
using System.Text.RegularExpressions;

namespace _8.ExtractQuotations
{
    public class ExtractQuotations
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var pattern = @"('|"")(.+?)\1";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
