using System;
using System.Text.RegularExpressions;

namespace _06.SentenceExtractor
{
    public class SentenceExtractor
    {
        public static void Main()
        {
            var keyword = Console.ReadLine();
            var text = Console.ReadLine();

            var pattern = $@".+?\s{keyword}\s.+?[!\.?]";
            var regex = new Regex(pattern);
            var matches = isSentence(text);

            foreach (Match match in matches)
            {
                var rgx = new Regex($@"\b{keyword}\b");
                var containsKeyword = rgx.IsMatch(match.Value);

                if (containsKeyword)
                {
                    Console.WriteLine(match.Value.Trim());
                }
            }
        }

        private static MatchCollection isSentence(string text)
        {
            var pattern = @"[^!?.]+[!?.]";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            return matches;
        }
    }
}
