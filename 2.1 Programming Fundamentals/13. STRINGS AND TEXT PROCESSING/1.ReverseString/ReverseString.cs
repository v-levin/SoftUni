using System;
using System.Text;

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
            var sb = new StringBuilder();

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                sb.Append(inputString[i]);
            }

            return sb.ToString();
        }
    }
}
