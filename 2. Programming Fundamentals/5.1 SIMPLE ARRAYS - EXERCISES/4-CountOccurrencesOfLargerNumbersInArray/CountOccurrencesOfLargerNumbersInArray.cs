using System;
using System.Linq;

namespace _4_CountOccurrencesOfLargerNumbersInArray
{
    class CountOccurrencesOfLargerNumbersInArray
    {
        static void Main()
        {
            double[] arrNumbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            double p = double.Parse(Console.ReadLine());
            int count = 0;

            foreach (var number in arrNumbers)
            {
                if (number > p)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
