using System;
using System.Linq;

namespace _5_IncreasingSequenceOfElements
{
    class IncreasingSequenceOfElements
    {
        static void Main()
        {
            int[] arrNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool check = true;

            for (int i = 0; i < arrNumbers.Length - 1; i++)
            {
                int prevNumber = arrNumbers[i];
                int nextNumber = arrNumbers[i + 1];

                if (prevNumber > nextNumber)
                {
                    check = false;
                    break;
                }
            }

            if (check)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
