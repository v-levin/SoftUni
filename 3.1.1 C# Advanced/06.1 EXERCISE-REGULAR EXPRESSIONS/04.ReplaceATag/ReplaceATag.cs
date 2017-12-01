using System;
using System.Text.RegularExpressions;

namespace _04.ReplaceATag
{
    public class ReplaceATag
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"<a\.*(.+?)>(.+?)<\/a>";

            while (input != "end")
            {
                input = Regex.Replace(input, pattern, @"[URL$1]$2[/URL]");
                Console.WriteLine(input);

                input = Console.ReadLine();
            }
        }
    }
}
