﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.OddOccurrences
{
    class OddOccurrences
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 0;
                }

                result[word]++;
            }

            var oddNumberWords = new List<string>();

            foreach (var kvp in result)
            {
                if (kvp.Value % 2 != 0)
                {
                    oddNumberWords.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddNumberWords));
        }
    }
}
