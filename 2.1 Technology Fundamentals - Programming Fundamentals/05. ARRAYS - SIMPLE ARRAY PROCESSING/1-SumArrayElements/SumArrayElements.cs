using System;

namespace _1_SumArrayElements
{
    public class SumArrayElements
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                numbers[i] = currentNumber;

                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
