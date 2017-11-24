using System;

namespace _4.SpecialWords
{
    public class SpecialWords
    {
        public static void Main()
        {
            var specialWords = Console.ReadLine().Split(' ');
            var text = Console.ReadLine().Split(new[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var specialWord in specialWords)
            {
                var counter = 0;

                foreach (var word in text)
                {
                    if (specialWord == word)
                    {
                        counter++;
                    }
                }

                Console.WriteLine($"{specialWord} - {counter}");
            }
        }
    }
}
