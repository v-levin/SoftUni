using System;

namespace _1.ReverseString
{
    public class ReverseStrings
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();

            Console.WriteLine(ReverseString(inputString));
        }

        private static string ReverseString(string inputString)
        {
            var charArray = inputString.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
