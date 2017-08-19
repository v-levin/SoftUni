using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var previousSum = 0;
            var currentSum = 0;
            var maxDiff = int.MinValue;
            var diff = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var currentNumber = int.Parse(Console.ReadLine());
                    currentSum += currentNumber;
                }

                if (n == 1) maxDiff = 0;

                if (i > 0)
                {
                    diff = Math.Abs(currentSum - previousSum);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }

                previousSum = currentSum;
                currentSum = 0;
            }
            
            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={previousSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }

        }
    }
}
