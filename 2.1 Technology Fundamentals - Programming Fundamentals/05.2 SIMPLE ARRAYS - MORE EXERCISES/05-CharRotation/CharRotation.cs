using System;
using System.Linq;

namespace _05_CharRotation
{
    class CharRotation
    {
        static void Main()
        {
            string characters = Console.ReadLine();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string result = string.Empty;
            
            for (int i = 0; i < characters.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += (char)(characters[i] - numbers[i]);
                }
                else
                {
                    result += (char)(characters[i] + numbers[i]);
                }
            }

            Console.WriteLine(result);
         }
    }
}
