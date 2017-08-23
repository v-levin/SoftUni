using System;
namespace _1.ValueOfAString
{
    public class ValueOfAString
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var charsToSum = Console.ReadLine();

            var sumOfLowercase = 0;
            var sumOfUppercase = 0;

            foreach (var letter in inputLine)
            {
                if (char.IsLower(letter))
                {
                    sumOfLowercase += letter;
                }
                else if (char.IsUpper(letter))
                {
                    sumOfUppercase += letter;
                }
            }

            if (charsToSum == "LOWERCASE")
            {
                PrintSum(sumOfLowercase);
            }
            else if (charsToSum == "UPPERCASE")
            {
                PrintSum(sumOfUppercase);
            }
        }

        private static void PrintSum(int sum)
        {
            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}
