using System;

namespace _7_NumbersToWords
{
    class NumbersToWords
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                string numbersAsWords = Letterize(num);

                Console.WriteLine(numbersAsWords);
            }
        }

        static string Letterize(int number)
        {
            string result = string.Empty;
            string minus = string.Empty;

            if (number.ToString().Length < 3)
            {
                return result;
            }
            else if (number > 999)
            {
                result = "too large";
                return result;
            }
            else if (number < -999)
            {
                result = "too small";
                return result;
            }
            else if (number < 0)
            {
                minus = "minus ";
            }

            string[] oneToTen = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            string[] tenToTwenty = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] twentyToHundred = { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred"};
            
            int d3 = number % 10;
            number /= 10;
            int d2 = number % 10;
            number /= 10;
            int d1 = number % 10;

            string digit1 = string.Empty;
            string digit2 = string.Empty;
            string digit3 = string.Empty;
            
            digit1 = oneToTen[Math.Abs(d1)] + "-hundred";

            if (Math.Abs(d2) == 1)
            {
                digit2 = tenToTwenty[Math.Abs(d3)];
                return result = minus + digit1 + " and " + digit2;
            }
            else if (Math.Abs(d2) == 0 && Math.Abs(d3) != 0)
            {
                digit3 = oneToTen[Math.Abs(d3)];
                return result = minus + digit1 + " and " + digit3;
            }
            else if (Math.Abs(d2) == 0 && Math.Abs(d3) == 0)
            {
                return result = minus + digit1;
            }
            else if (Math.Abs(d3) == 0)
            {
                digit3 = twentyToHundred[Math.Abs(d2)];
                return result = minus + digit1 + " and " + digit3;
            }
            
            digit2 = twentyToHundred[Math.Abs(d2)];
            digit3 = oneToTen[Math.Abs(d3)];
            
            result = minus + digit1 + " and " + digit2 + " " + digit3;

            return result;
        }
    }
}
