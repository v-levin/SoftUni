using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.StringMatrixRotation
{
    public class StringMatrixRotation
    {
        public static void Main()
        {
            var rotation = Console.ReadLine().Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            var rotationDegrees = int.Parse(rotation[1]) % 360;

            var stringsQueue = new Queue<string>();

            var line = Console.ReadLine();

            while (line != "END")
            {
                stringsQueue.Enqueue(line);

                line = Console.ReadLine();
            }

            var longestStringCount = stringsQueue.Max(s => s.Count());

            var matrix = new List<List<char>>();

            BuildRectangularMatrix(stringsQueue, longestStringCount, matrix);

            if (rotationDegrees == 0)
            {
                PrintMatrix(matrix);
            }
            else if (rotationDegrees == 90)
            {
                var newMatrix = new List<List<char>>();
                Rotate90(matrix, newMatrix);
                PrintMatrix(newMatrix);
            }
            else if (rotationDegrees == 180)
            {
                Rotate180(matrix);
                PrintMatrix(matrix);
            }
            else if (rotationDegrees == 270)
            {
                var newMatrix = new List<List<char>>();
                Rotate90(matrix, newMatrix);
                Rotate180(newMatrix);
                PrintMatrix(newMatrix);
            }
        }

        private static void BuildRectangularMatrix(Queue<string> stringsQueue, int longestStringCount, List<List<char>> matrix)
        {
            while (stringsQueue.Count > 0)
            {
                var currentElemetsCount = stringsQueue.Peek().Count();
                var spacesToFill = new string(' ', longestStringCount - currentElemetsCount);
                matrix.Add(stringsQueue.Dequeue().ToList().Concat(spacesToFill).ToList());
            }
        }

        private static void Rotate90(List<List<char>> matrix, List<List<char>> newMatrix)
        {
            for (int i = 0; i < matrix[0].Count; i++)
            {
                newMatrix.Add(new string(' ', matrix.Count).ToList());
            }

            for (int i = 0; i < matrix[0].Count; i++)
            {
                for (int j = 0; j < matrix.Count; j++)
                {
                    newMatrix[i][j] = matrix[matrix.Count - 1 - j][i];
                }
            }
        }

        private static void Rotate180(List<List<char>> matrix)
        {
            for (int i = 0; i < matrix.Count / 2; i++)
            {
                var temp = matrix[i];
                matrix[i] = matrix[matrix.Count - 1 - i];
                matrix[matrix.Count - 1 - i] = temp;
            }

            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count / 2; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[i][matrix[i].Count - 1 - j];
                    matrix[i][matrix[i].Count - 1 - j] = temp;
                }
            }
        }

        private static void PrintMatrix(List<List<char>> matrix)
        {
            foreach (var elements in matrix)
            {
                Console.WriteLine(string.Join("", elements));
            }
        }
    }
}
