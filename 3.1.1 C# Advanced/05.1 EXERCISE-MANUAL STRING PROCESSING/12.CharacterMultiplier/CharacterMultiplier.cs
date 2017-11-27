using System;

namespace _12.CharacterMultiplier
{
    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var str1 = input[0];
            var str2 = input[1];

            var result = MultiplyCharacters(str1, str2);
            Console.WriteLine(result);
        }

        private static int MultiplyCharacters(string str1, string str2)
        {
            var result = 0;
            var minLength = Math.Min(str1.Length, str2.Length);

            for (int i = 0; i < minLength; i++)
            {
                result += str1[i] * str2[i];
            }

            if (str1.Length > str2.Length)
            {
                for (int i = minLength; i < str1.Length; i++)
                {
                    result += str1[i];
                }
            }
            else if (str2.Length > str1.Length)
            {
                for (int i = minLength; i < str2.Length; i++)
                {
                    result += str2[i];
                }
            }

            return result;
        }
    }
}
