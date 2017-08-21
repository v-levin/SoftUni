using System;

namespace _1_MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int result = GetMultipleOfEvensAndOdds(n);

            Console.WriteLine(result);
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            int result = 0;
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);

            result = evenSum * oddSum;

            return result;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;

            while (Math.Abs(number) > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }

                number /= 10;
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;

            while (Math.Abs(number) > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }

                number /= 10;
            }

            return oddSum;
        }
    }
}
