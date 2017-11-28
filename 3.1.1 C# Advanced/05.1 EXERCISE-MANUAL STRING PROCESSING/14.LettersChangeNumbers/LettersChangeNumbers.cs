using System;

namespace _14.LettersChangeNumbers
{
    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var strings = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            var sum = 0m;
            foreach (var str in strings)
            {
                var firstLetter = str[0];
                var num = decimal.Parse(str.Substring(1, str.Length - 2));
                var lastLetter = str[str.Length - 1];

                if (char.IsUpper(firstLetter))
                {
                    sum += num / GetIndexInAlphabet(firstLetter);
                }
                else
                {
                    sum += num * GetIndexInAlphabet(firstLetter);
                }

                if (char.IsUpper(lastLetter))
                {
                    sum -= GetIndexInAlphabet(lastLetter);
                }
                else
                {
                    sum += GetIndexInAlphabet(lastLetter);
                }
            }

            Console.WriteLine($"{sum:F2}");
        }

        public static int GetIndexInAlphabet(char letter)
        {
            return letter % 32;
        }
    }
}
