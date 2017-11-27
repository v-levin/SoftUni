using System;
using System.Collections.Generic;

namespace _13.MagicExchangeableWords
{
    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var firstString = input[0];
            var secondString = input[1];

            var mappedChars = new Dictionary<char, char>();

            var shorterString = string.Empty;
            var longerString = string.Empty;
            if (firstString.Length > secondString.Length)
            {
                shorterString = secondString;
                longerString = firstString;
            }
            else if (firstString.Length < secondString.Length)
            {
                shorterString = firstString;
                longerString = secondString;
            }

            var magicWord = true;
            for (int i = 0; i < shorterString.Length; i++)
            {
                if (!mappedChars.ContainsKey(longerString[i]))
                {
                    mappedChars.Add(longerString[i], shorterString[i]);
                }
                else if (mappedChars[longerString[i]] != shorterString[i])
                {
                    magicWord = false;
                    break;
                }
            }

            if (magicWord)
            {
                for (int i = shorterString.Length; i < longerString.Length; i++)
                {
                    if (!mappedChars.ContainsKey(longerString[i]))
                    {
                        magicWord = false;
                        break;
                    }
                }
            }

            Console.WriteLine(magicWord.ToString().ToLower());
        }
    }
}
