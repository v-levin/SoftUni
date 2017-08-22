using System;

namespace _2.CountSubstringOccurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            var inputString = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            var count = 0;
            var index = -1;

            while (true)
            {
                index = inputString.IndexOf(pattern, index + 1);

                if (index < 0)
                {
                    break;
                }

                count++;
            }

            Console.WriteLine(count);
        }
    }
}
