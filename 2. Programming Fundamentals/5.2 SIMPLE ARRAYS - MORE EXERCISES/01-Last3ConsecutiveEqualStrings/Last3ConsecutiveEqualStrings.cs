using System;

namespace _01_Last3ConsecutiveEqualStrings
{
    class Last3ConsecutiveEqualStrings
    {
        static void Main()
        {
            string[] arrStrings = Console.ReadLine().Split(' ');

            string result = string.Empty;

            for (int i = arrStrings.Length - 1; i > 0; i--)
            {
                if (arrStrings[i] == arrStrings[i - 1] && arrStrings[i] == arrStrings[i - 2])
                {
                    Console.WriteLine($"{arrStrings[i]} {arrStrings[i]} {arrStrings[i]}");
                    break;
                }
            }
        }
    }
}
