using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Crossfire
{
    public class Crossfire
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var matrixRow = int.Parse(matrixSize[0]);
            var matrixCol = int.Parse(matrixSize[1]);

            var matrix = new List<List<int>>();
            FillTheMatrix(matrixRow, matrixCol, matrix);

            var input = Console.ReadLine();

            while (input != "Nuke it from orbit")
            {
                var coordinates = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var targetRow = int.Parse(coordinates[0]);
                var targetCol = int.Parse(coordinates[1]);
                var radius = int.Parse(coordinates[2]);

                DestroyTheMatrix(matrix, targetRow, targetCol, radius);
                RemoveEmptyCells(matrix);

                input = Console.ReadLine();
            }

            foreach (var elements in matrix)
            {
                Console.WriteLine(string.Join(" ", elements));
            }
        }

        private static void FillTheMatrix(int row, int col, List<List<int>> matrix)
        {
            var counter = 1;
            for (int i = 0; i < row; i++)
            {
                matrix.Add(new List<int>());

                for (int j = 0; j < col; j++)
                {
                    matrix[i].Add(counter);
                    counter++;
                }
            }
        }

        private static void DestroyTheMatrix(List<List<int>> matrix, int targetRow, int targetCol, int radius)
        {
            if (targetRow >= 0 && targetRow < matrix.Count)
            {
                var startCol = Math.Max(0, targetCol - radius);
                var endCol = Math.Min(targetCol + radius, matrix[targetRow].Count - 1);

                for (int i = startCol; i <= endCol; i++)
                {
                    matrix[targetRow][i] = 0;
                }
            }

            if (targetCol >= 0 && targetCol < matrix[0].Count)
            {
                var startRow = Math.Max(0, targetRow - radius);
                var endRow = Math.Min(targetRow + radius, matrix.Count - 1);

                for (int i = startRow; i <= endRow; i++)
                {
                    if (targetCol < matrix[i].Count)
                    {
                        matrix[i][targetCol] = 0;
                    }
                }
            }
        }

        private static void RemoveEmptyCells(List<List<int>> matrix)
        {
            for (int rowIndex = 0; rowIndex < matrix.Count; rowIndex++)
            {
                matrix[rowIndex] = matrix[rowIndex].Where(n => n != 0).ToList();

                if (matrix[rowIndex].Count > 0)
                {
                    matrix[rowIndex].RemoveAll(n => n == 0);
                }
                else
                {
                    matrix.RemoveAt(rowIndex);
                    rowIndex--;
                }
            }
        }
    }
}
