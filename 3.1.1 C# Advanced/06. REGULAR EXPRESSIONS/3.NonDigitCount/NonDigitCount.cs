using System;
using System.Text.RegularExpressions;

namespace _3.NonDigitCount
{
    public class NonDigitCount
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var pattern = @"\D";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            Console.WriteLine($"Non-digits: {matches.Count}");
        }
    }
}
