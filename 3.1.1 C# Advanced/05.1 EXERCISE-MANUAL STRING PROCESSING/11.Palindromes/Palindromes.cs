using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new List<string>();

            var isPalindrom = true;
            foreach (var word in text)
            {
                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isPalindrom = false;
                        break;
                    }
                }

                if (isPalindrom)
                {
                    palindromes.Add(word);
                }

                isPalindrom = true;
            }

            Console.WriteLine($"[{string.Join(", ", palindromes.Distinct().OrderBy(w => w))}]");
        }
    }
}
