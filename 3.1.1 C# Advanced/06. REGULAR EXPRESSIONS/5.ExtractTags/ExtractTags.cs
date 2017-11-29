using System;
using System.Text.RegularExpressions;

namespace _5.ExtractTags
{
    public class ExtractTags
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"<.+?>";
            var regex = new Regex(pattern);

            while (input != "END")
            {
                var matches = regex.Matches(input);

                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }

                input = Console.ReadLine();
            }
        }
    }
}
