using System;
using System.Text.RegularExpressions;

namespace _2.VowelCount
{
    public class VowelCount
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var pattern = @"[aeiouyAEIOUY]";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            Console.WriteLine($"Vowels: {matches.Count}");
        }
    }
}
