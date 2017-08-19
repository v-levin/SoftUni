using System;
using System.Linq;

namespace _2.AverageCharacterDelimiter
{
    class AverageCharacterDelimiter
    {
        static void Main()
        {
            var strings = Console.ReadLine()
                .Split()
                .ToArray();

            var sum = 0;
            var countOfLetters = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                foreach (var character in strings[i])
                {
                    sum += character;
                    countOfLetters++;
                }
            }

            var averageChar = sum / countOfLetters;
            var averageCharToUpper = Char.ToUpper((char)averageChar);
            
            Console.WriteLine(string.Join(averageCharToUpper.ToString(), strings));
        }
    }
}
