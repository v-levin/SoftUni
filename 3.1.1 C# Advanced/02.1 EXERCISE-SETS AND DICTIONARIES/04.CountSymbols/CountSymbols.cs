using System;
using System.Collections.Generic;

namespace _04.CountSymbols
{
    public class CountSymbols
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var countSymbols = new SortedDictionary<char, int>();

            foreach (var character in text)
            {
                if (!countSymbols.ContainsKey(character))
                {
                    countSymbols.Add(character, 1);
                    continue;
                }

                countSymbols[character]++;
            }

            foreach (var kvp in countSymbols)
            {
                var symbol = kvp.Key;
                var count = kvp.Value;

                Console.WriteLine($"{symbol}: {count} time/s");
            }
        }
    }
}
