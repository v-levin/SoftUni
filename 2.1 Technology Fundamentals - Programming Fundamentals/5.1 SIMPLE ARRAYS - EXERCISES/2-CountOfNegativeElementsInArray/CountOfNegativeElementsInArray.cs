using System;

namespace _2_CountOfNegativeElementsInArray
{
    class CountOfNegativeElementsInArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrNumbers = new int[n];
            int negativeNumbersCount = 0;

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                arrNumbers[i] = int.Parse(Console.ReadLine());

                if (arrNumbers[i] < 0)
                {
                    negativeNumbersCount++;
                }
            }

            Console.WriteLine(negativeNumbersCount);
        }
    }
}
