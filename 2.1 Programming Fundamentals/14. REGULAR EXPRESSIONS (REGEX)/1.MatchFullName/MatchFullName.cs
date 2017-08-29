using System;
using System.Text.RegularExpressions;

namespace _1.MatchFullName
{
    public class MatchFullName
    {
        public static void Main()
        {
            var names = Console.ReadLine();

            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            var regex = new Regex(pattern);

            var matchedNames = regex.Matches(names);

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
