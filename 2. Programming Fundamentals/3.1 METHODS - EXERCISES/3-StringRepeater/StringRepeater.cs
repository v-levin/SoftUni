using System;

namespace _3_StringRepeater
{
    class StringRepeater
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string repeatedString = RepeatString(str, count);

            Console.WriteLine(repeatedString);
        }

        static string RepeatString(string str, int count)
        {
            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += str;
            }

            return result;
        }
    }
}
