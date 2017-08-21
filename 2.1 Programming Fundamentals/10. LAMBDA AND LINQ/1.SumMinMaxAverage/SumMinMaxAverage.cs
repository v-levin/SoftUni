using System;
using System.Linq;

namespace _1.SumMinMaxAverage
{
    public class SumMinMaxAverage
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());

                nums[i] = currentNum;
            }

            Console.WriteLine($"Sum = {nums.Sum()}");
            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Average = {nums.Average()}");
        }
    }
}
