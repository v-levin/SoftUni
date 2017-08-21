using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main()
        {
            var words = Console.ReadLine()
                .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' })
                .ToList();

            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();

            foreach (var word in words)
            {
                if (word.All(char.IsLower) && !word.Equals(""))
                {
                    lowerCaseWords.Add(word);
                }
                else if (word.All(char.IsUpper) && !word.Equals(""))
                {
                    upperCaseWords.Add(word);
                }
                else if (!word.Equals(""))
                {
                    mixedCaseWords.Add(word);
                }
            }
            
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }
    }
}
