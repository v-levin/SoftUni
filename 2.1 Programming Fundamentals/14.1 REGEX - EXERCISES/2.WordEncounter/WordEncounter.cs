using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2.WordEncounter
{
    public class WordEncounter
    {
        public static void Main()
        {
            var words = new List<string>();

            var filter = Console.ReadLine();

            var sentence = Console.ReadLine();

            while (sentence != "end")
            {
                var patternForValidString = @"^[A-Z].*[\.?!]$";

                var regex = new Regex(patternForValidString);

                var isValid = regex.IsMatch(sentence);

                if (isValid)
                {
                    var pattern = @"\w+";

                    var allWords = Regex.Matches(sentence, pattern);

                    var letterToCheck = filter[0];
                    var letterCount = int.Parse(filter[1].ToString());

                    foreach (Match word in allWords)
                    {
                        GetValidWords(words, letterToCheck, letterCount, word);
                    }
                }

                sentence = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", words));
        }

        private static void GetValidWords(List<string> words, char letterToCheck, int letterCount, Match word)
        {
            var currentWord = word.Value;
            var count = 0;

            for (int i = 0; i < currentWord.Length; i++)
            {
                var currentLetter = currentWord[i];

                if (currentLetter == letterToCheck)
                {
                    count++;
                }
            }

            if (count >= letterCount)
            {
                words.Add(currentWord);
            }
        }
    }
}
