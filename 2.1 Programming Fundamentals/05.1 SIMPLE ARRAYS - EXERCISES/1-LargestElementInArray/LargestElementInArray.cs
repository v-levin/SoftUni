using System;

namespace _1_LargestElementInArray
{
    class LargestElementInArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrNumbers = new int[n];
            int maxValue = int.MinValue;

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                arrNumbers[i] = currentNumber;

                if (currentNumber > maxValue)
                {
                    maxValue = currentNumber;
                }
            }

            Console.WriteLine(maxValue);
        }
    }
}
