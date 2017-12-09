using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    public class ReverseAndExclude
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            
            Func<int[], int[]> reverse = ReverseArrayOfNumbers;
            var reversedNumbers = reverse(numbers);
            Predicate<int> divisibleByN = num => num % n == 0;

            PrintNumbers(reversedNumbers, divisibleByN);
        }

        private static void PrintNumbers(int[] reversedNumbers, Predicate<int> divisibleByN)
        {
            var result = new List<int>();

            foreach (var num in reversedNumbers)
            {
                if (!divisibleByN(num))
                {
                    result.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] ReverseArrayOfNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                var temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }

            return numbers;
        }
    }
}
