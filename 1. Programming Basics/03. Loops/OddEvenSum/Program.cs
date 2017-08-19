using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if ((i + 1) % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                var diff = Math.Abs(oddSum - evenSum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
