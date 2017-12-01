using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.ExtractHyperlinks
{
    public class ExtractHyperlinks
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var text = new StringBuilder();

            while (inputLine != "END")
            {
                text.Append(inputLine + " ");

                inputLine = Console.ReadLine();
            }

            var pattern = @"<a.*?(?<!"">)href\s*=\s*(['""])?(.*?)(?:>|class|\1)";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text.ToString());

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value.Trim());
            }
        }
    }
}
