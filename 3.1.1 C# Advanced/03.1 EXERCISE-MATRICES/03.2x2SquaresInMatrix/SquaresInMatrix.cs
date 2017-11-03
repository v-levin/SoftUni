using System;
using System.Linq;

namespace _03._2x2SquaresInMatrix
{
    public class SquaresInMatrix
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rows = matrixSize[0];
            var cols = matrixSize[1];

            var matrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                var currentRow = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                matrix[i] = currentRow;
            }

            var counter = 0;
            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    if (matrix[i][j] == matrix[i][j + 1] && matrix[i][j] == matrix[i + 1][j] && matrix[i][j + 1] == matrix[i + 1][j + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
