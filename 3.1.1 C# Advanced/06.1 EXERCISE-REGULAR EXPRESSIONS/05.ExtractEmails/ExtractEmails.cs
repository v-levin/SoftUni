using System;
using System.Text.RegularExpressions;

namespace _05.ExtractEmails
{
    public class ExtractEmails
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var pattern = @"(?<= )([a-zA-Z]+)[-_\.]?\w+?@[a-zA-Z]+[-]?[a-zA-Z]+\.[a-zA-Z]+\.?[a-zA-Z]+";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
