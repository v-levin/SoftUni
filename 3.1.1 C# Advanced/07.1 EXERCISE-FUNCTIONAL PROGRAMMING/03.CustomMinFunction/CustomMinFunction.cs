using System;

namespace _03.CustomMinFunction
{
    public class CustomMinFunction
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split();
            Func<string[], int> minFunc = GetMinNumber;

            var minNumber = minFunc(numbers);
            Console.WriteLine(minNumber);
        }

        private static int GetMinNumber(string[] numbers)
        {
            var min = int.MaxValue;

            foreach (var number in numbers)
            {
                if (int.Parse(number) < min)
                {
                    min = int.Parse(number);
                }
            }

            return min;
        }
    }
}
