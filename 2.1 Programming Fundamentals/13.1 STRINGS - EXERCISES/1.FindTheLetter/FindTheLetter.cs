using System;

namespace _1.FindTheLetter
{
    public class FindTheLetter
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var elements = Console.ReadLine().Split();

            var letter = elements[0];
            var integerN = int.Parse(elements[1]);
            
            var index = -1;

            for (int i = 0; i < integerN; i++)
            {
                index = text.IndexOf(letter, index + 1);
            }

            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}
