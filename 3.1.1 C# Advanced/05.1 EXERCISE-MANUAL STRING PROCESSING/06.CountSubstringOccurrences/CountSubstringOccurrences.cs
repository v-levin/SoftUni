using System;

namespace _06.CountSubstringOccurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var searchString = Console.ReadLine().ToLower();

            Console.WriteLine(CountStringOccurences(text, searchString));
        }

        private static int CountStringOccurences(string text, string searchString)
        {
            var count = 0;
            var indexOfSubstring = text.IndexOf(searchString);

            while (indexOfSubstring != -1)
            {
                count++;
                indexOfSubstring = text.IndexOf(searchString, indexOfSubstring + 1);
            }

            return count;
        }
    }
}
