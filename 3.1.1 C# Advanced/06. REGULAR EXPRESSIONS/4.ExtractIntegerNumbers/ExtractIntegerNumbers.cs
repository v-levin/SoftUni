using System;
using System.Text.RegularExpressions;

namespace _4.ExtractIntegerNumbers
{
    public class ExtractIntegerNumbers
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var pattern = @"\d+";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            foreach (Match number in matches)
            {
                Console.WriteLine(number);
            }
        }
    }
}
