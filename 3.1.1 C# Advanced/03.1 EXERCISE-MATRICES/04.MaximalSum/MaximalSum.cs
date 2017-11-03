using System;
using System.Linq;

namespace _04.MaximalSum
{
    public class MaximalSum
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var rows = matrixSize[0];
            var cols = matrixSize[1];

            var matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                var currentRow = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                matrix[i] = currentRow;
            }
            
            var rowIndexStart = 0;
            var colIndexStart = 0;
            var sum = int.MinValue;
            for (int i = 0; i < matrix.Length - 2; i++)
            {
                for (int j = 0; j < matrix[i].Length - 2; j++)
                {
                    var currentSum = matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2] +
                                    matrix[i + 1][j] + matrix[i + 1][j + 1] + matrix[i + 1][j + 2] +
                                    matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2];

                    if (currentSum > sum)
                    {
                        sum = currentSum;

                        rowIndexStart = i;
                        colIndexStart = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");

            for (int i = rowIndexStart; i < rowIndexStart + 3; i++)
            {
                for (int j = colIndexStart; j < colIndexStart + 3; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
