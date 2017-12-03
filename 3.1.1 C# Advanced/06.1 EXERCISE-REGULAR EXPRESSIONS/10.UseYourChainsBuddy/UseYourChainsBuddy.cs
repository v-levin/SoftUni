using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _10.UseYourChainsBuddy
{
    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pTagPattern = @"<p>(.+?)</p>";
            var regex = new Regex(pTagPattern);
            var matches = regex.Matches(input);

            var result = new StringBuilder();
            var whiteSpaces = @"[^a-z0-9]+";
            foreach (Match match in matches)
            {
                var stringToConvert = Regex.Replace(match.Groups[1].Value, whiteSpaces, " ");
                result.Append(DecryptText(stringToConvert));
            }

            Console.WriteLine(result);
        }

        private static string DecryptText(string stringToConvert)
        {
            var result = string.Empty;

            foreach (var letter in stringToConvert)
            {
                if (letter >= 'a' && letter <= 'm')
                {
                    result += (char)(letter + 13);
                }
                else if (letter >= 'n' && letter <= 'z')
                {
                    result += (char)(letter - 13);
                }
                else
                {
                    result += letter;
                }
            }

            return result;
        }
    }
}
