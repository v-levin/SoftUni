using System;

namespace NumberToText
{
    class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            string[] arrToNineteen = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
            "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            string[] arrToOneHundred = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "one hundred" };

            if (num >= 0 && num < 20)
            {
                Console.WriteLine(arrToNineteen[num]);
            }
            else if (num >= 20 && num <= 100)
            {
                if (num % 10 == 0)
                {
                    num /= 10;
                    Console.WriteLine(arrToOneHundred[num - 2]);
                }
                else
                {
                    Console.WriteLine($"{arrToOneHundred[num / 10 - 2]} {arrToNineteen[num % 10]}");
                }
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}