using System;
using System.Linq;

namespace _2.MaximumSumOf2x2Submatrix
{
    public class MaximumSumOf2x2Submatrix
    {
        public static void Main()
        {
            var matrixSizes = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var rows = int.Parse(matrixSizes[0]);
            var matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            var maxSquareRow = 0;
            var maxSquareCol = 0;
            var maxSum = int.MinValue;

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    var currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row + 1][col] + matrix[row + 1][col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSquareRow = row;
                        maxSquareCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxSquareRow][maxSquareCol]} {matrix[maxSquareRow][maxSquareCol + 1]}\n" +
                $"{matrix[maxSquareRow + 1][maxSquareCol]} {matrix[maxSquareRow + 1][maxSquareCol + 1]}\n" +
                $"{maxSum}");
        }
    }
}
