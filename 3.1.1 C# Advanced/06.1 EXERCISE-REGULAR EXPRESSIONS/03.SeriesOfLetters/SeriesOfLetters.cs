using System;
using System.Text.RegularExpressions;

namespace _03.SeriesOfLetters
{
    public class SeriesOfLetters
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"(\w)\1+";
            var regex = new Regex(pattern);
            var match = regex.Match(input);

            var result = regex.Replace(input, "$1");

            Console.WriteLine(result);
        }
    }
}
