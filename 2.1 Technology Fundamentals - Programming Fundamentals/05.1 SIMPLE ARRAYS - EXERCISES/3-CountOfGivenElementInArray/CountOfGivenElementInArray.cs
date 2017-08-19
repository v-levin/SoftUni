using System;
using System.Linq;

namespace _3_CountOfGivenElementInArray
{
    class CountOfGivenElementInArray
    {
        static void Main()
        {
            int[] arrNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int numberToCheck = int.Parse(Console.ReadLine());
            int count = 0;

            foreach (var number in arrNumbers)
            {
                if (number == numberToCheck)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
