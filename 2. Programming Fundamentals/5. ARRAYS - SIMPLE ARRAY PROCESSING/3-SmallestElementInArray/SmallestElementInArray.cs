using System;
using System.Linq;


namespace _3_SmallestElementInArray
{
    class SmallestElementInArray
    {
        static void Main()
        {
            int[] arrNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int minNumber = int.MaxValue;

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                int currentNumber = arrNumbers[i];

                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }

            Console.WriteLine(minNumber);
        }
    }
}
