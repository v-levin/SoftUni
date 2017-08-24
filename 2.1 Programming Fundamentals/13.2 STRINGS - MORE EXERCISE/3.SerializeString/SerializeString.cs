using System;
using System.Collections.Generic;

namespace _3.SerializeString
{
    public class SerializeString
    {
        public static void Main()
        {
            var letters = new Dictionary<string, List<int>>();

            var inputLine = Console.ReadLine();

            for (int i = 0; i < inputLine.Length; i++)
            {
                var letter = inputLine[i].ToString();

                if (!letters.ContainsKey(letter))
                {
                    letters[letter] = new List<int>();
                }

                letters[letter].Add(i);
            }

            foreach (var letter in letters)
            {
                Console.WriteLine($"{letter.Key}:{string.Join("/", letter.Value)}");               
            }
        }
    }
}
