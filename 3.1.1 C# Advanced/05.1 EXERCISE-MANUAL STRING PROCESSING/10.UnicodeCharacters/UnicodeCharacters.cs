using System;
using System.Text;

namespace _10.UnicodeCharacters
{
    public class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new StringBuilder();

            foreach (var character in input)
            {
                var unicode = ((int)character).ToString("X4").ToLower();
                result.Append($"\\u{unicode}");
            }

            Console.WriteLine(result);
        }
    }
}
