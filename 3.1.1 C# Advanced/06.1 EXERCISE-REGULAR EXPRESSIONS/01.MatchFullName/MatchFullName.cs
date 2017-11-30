using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    public class MatchFullName
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"[A-Z][a-z]+\s[A-Z][a-z]+$";
            var regex = new Regex(pattern);

            while (input != "end")
            {
                var match = regex.Match(input);

                if (match.Success)
                {
                    Console.WriteLine(match);
                }

                input = Console.ReadLine();
            }
        }
    }
}
