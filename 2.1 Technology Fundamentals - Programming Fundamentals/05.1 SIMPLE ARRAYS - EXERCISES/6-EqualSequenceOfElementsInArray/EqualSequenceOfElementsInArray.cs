using System;
using System.Linq;

namespace _6_EqualSequenceOfElementsInArray
{
    class EqualSequenceOfElementsInArray
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
                int nextNumebr = arrNumbers[i + 1];

                if (prevNumber != nextNumebr)
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
