using System;
using System.Text.RegularExpressions;

namespace _6.ReplaceATag
{
    public class ReplaceATag
    {
        public static void Main()
        {

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var regex = @"<a\s+href=(.+?)>(.+?)<\/a>";

                var replacement = @"[URL href=$1]$2[/URL]";

                var replaced = Regex.Replace(inputLine, regex, replacement);

                Console.WriteLine(replaced);

                inputLine = Console.ReadLine();
            }
        }
    }
}
