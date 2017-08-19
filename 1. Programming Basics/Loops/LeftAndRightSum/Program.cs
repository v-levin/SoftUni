using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfSides = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < numberOfSides; i++)
            {
                var leftSide = int.Parse(Console.ReadLine());
                leftSum += leftSide;
            }

            for (int j = 0; j < numberOfSides; j++)
            {
                var rightSide = int.Parse(Console.ReadLine());
                rightSum += rightSide;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                var diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
