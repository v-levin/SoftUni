using System;
using System.Collections.Generic;

namespace _1.LetterRepetition
{
    class LetterRepetition
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (!result.ContainsKey(character))
                {
                    result[character] = 0;
                }

                result[character]++;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
