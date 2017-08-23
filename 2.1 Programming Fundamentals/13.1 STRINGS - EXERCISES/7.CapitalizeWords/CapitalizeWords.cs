using System;
using System.Collections.Generic;

namespace _7.CapitalizeWords
{
    public class CapitalizeWords
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var result = new List<string>();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(new[] { ' ', '.', ',', '!', '?', ':', '@', '$', '%', '*', '"', ';', '(', ')', '[', ']', '{', '}', '|', '#', '^', '&', '-', '+' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in inputParams)
                {
                    result.Add(UppercaseFirst(word));
                }

                Console.WriteLine(string.Join(", ", result));

                result.Clear();

                inputLine = Console.ReadLine();
            }
        }

        private static string UppercaseFirst(string word)
        {
            word = word.ToLower();
            char[] a = word.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}
