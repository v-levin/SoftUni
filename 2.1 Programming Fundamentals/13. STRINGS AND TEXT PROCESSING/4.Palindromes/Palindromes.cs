using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            var result = new List<string>();

            var text = Console.ReadLine();

            var words = text.Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                var palindrom = Palindrom(word);

                if (palindrom)
                {
                    result.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", result.Distinct().OrderBy(w => w)));
        }

        private static bool Palindrom(string word)
        {

            var reversedWord = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord.Append(word[i]);
            }

            if (word == reversedWord.ToString())
            {
                return true;
            }

            return false;
        }
    }
}
