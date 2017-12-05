using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _11.SemanticHTML
{
    public class SemanticHTML
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var openDivPattern = @"<(div\s+)(?:.+?|)((?:\s*id|\s*class)\s*=\s*['""](main|header|nav|article|section|aside|footer)['""])";
            var closeDivPattern = @"</div>\s*<!--\s*(\w+)\s*-->";

            var openDivRegex = new Regex(openDivPattern);
            var closeDivRegex = new Regex(closeDivPattern);

            var result = new StringBuilder();

            while (inputLine != "END")
            {
                var openDivMatch = openDivRegex.Match(inputLine);
                var closeDivMatch = closeDivRegex.Match(inputLine);

                if (openDivMatch.Success)
                {
                    inputLine = Regex.Replace(inputLine, openDivMatch.Groups[1].Value, openDivMatch.Groups[3].Value + " ");
                    inputLine = Regex.Replace(inputLine, openDivMatch.Groups[2].Value, string.Empty);
                    inputLine = Regex.Replace(inputLine, @"\s+", " ");
                    inputLine = Regex.Replace(inputLine, @"\s+>", ">");
                }

                if (closeDivMatch.Success)
                {
                    inputLine = Regex.Replace(inputLine, closeDivMatch.Groups[0].Value, $"</{closeDivMatch.Groups[1].Value}>");
                }

                result.Append($"{inputLine}{Environment.NewLine}");

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(result);
        }
    }
}
