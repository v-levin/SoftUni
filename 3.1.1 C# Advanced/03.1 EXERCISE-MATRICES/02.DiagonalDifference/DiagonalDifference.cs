using System;
using System.Linq;

namespace _02.DiagonalDifference
{
    public class DiagonalDifference
    {
        public static void Main()
        {
            var matrixSize = int.Parse(Console.ReadLine());

            var matrix = new int[matrixSize][];
            var primaryDiagonalSum = 0;
            var secondaryDiagonalSum = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                var currentRow = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                matrix[i] = currentRow;

                primaryDiagonalSum += matrix[i][i];
                secondaryDiagonalSum += matrix[i][matrix[i].Length - 1 - i];
            }

            var difference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);

            Console.WriteLine(difference);
        }
    }
}
