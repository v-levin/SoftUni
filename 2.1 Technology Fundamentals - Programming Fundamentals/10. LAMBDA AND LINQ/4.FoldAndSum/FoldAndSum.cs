using System;
using System.Linq;

namespace _4.FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var k = numbers.Length / 4;

            var firstPartUpperNumbers = numbers.Take(k).Reverse().ToArray();
            var secondPartUpperNumbers = numbers.Reverse().Take(k).ToArray();

            var upperNumbers = firstPartUpperNumbers.Concat(secondPartUpperNumbers).ToArray();
            var lowerNumbers = numbers.Skip(k).Take(2 * k).ToArray();

            var result = new int[upperNumbers.Length];

            for (int i = 0; i < upperNumbers.Length; i++)
            {
                result[i] = upperNumbers[i] + lowerNumbers[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
