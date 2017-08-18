using System;

namespace _4_NthDigit
{
    class NthDigit
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            int nthDigit = FindNthDigit(number, index);

            Console.WriteLine(nthDigit);
        }

        static int FindNthDigit(long number, int index)
        {
            int currentIndex = 1;

            while (number > 0)
            {

                if (currentIndex == index)
                {
                    return (int)(number % 10);
                }

                currentIndex++;
                number /= 10;
            }

            return (int)(number % 10);
        }
    }
}
