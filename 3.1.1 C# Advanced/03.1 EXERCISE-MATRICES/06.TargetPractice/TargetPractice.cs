using System;
using System.Linq;

namespace _06.TargetPractice
{
    public class TargetPractice
    {
        public static void Main()
        {
            var matrix = InitializeMatrix();

            GetDestroyedSymbols(matrix);

            ReArrangeMatrix(matrix);

            foreach (var symbols in matrix)
            {
                Console.WriteLine(string.Join("", symbols));
            }
        }

        private static void ReArrangeMatrix(char[][] matrix)
        {
            for (int i = matrix.Length - 1; i >= 0; i--)
            {
                for (int j = matrix[i].Length - 1; j >= 0; j--)
                {
                    if (matrix[i][j] == ' ')
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (matrix[k][j] != ' ')
                            {
                                matrix[i][j] = matrix[k][j];
                                matrix[k][j] = ' ';
                                break;
                            }
                        }
                    }
                }
            }
        }

        private static void GetDestroyedSymbols(char[][] matrix)
        {
            
            var shotParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var impactRow = int.Parse(shotParams[0]);
            var impactCol = int.Parse(shotParams[1]);
            var radius = int.Parse(shotParams[2]);

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (IsCellShot(i, j, impactRow, impactCol, radius))
                    {
                        matrix[i][j] = ' ';
                    }
                }
            }
        }

        private static bool IsCellShot(int i, int j, int impactRow, int impactCol, int radius)
        {
            var distance = Math.Sqrt(Math.Pow(i - impactRow, 2) + Math.Pow(j - impactCol, 2));

            return distance <= radius;
        }

        private static char[][] InitializeMatrix()
        {
            var matrixSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var rows = int.Parse(matrixSize[0]);
            var cols = int.Parse(matrixSize[1]);
            var matrix = new char[rows][].Select(r => r = new char[cols]).ToArray();

            var snake = Console.ReadLine();

            var snakeIndex = 0;
            for (int i = matrix.Length - 1; i >= 0; i--)
            {
                for (int j = matrix[i].Length - 1; j >= 0; j--)
                {
                    FillMatrixWithSnake(matrix, snake, ref snakeIndex, i, j);
                }

                i--;

                if (i < 0)
                {
                    break;
                }

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    FillMatrixWithSnake(matrix, snake, ref snakeIndex, i, j);
                }
            }

            return matrix;
        }

        private static void FillMatrixWithSnake(char[][] matrix, string snake, ref int snakeIndex, int i, int j)
        {
            if (snakeIndex > snake.Length - 1)
            {
                snakeIndex = 0;
            }

            matrix[i][j] = snake[snakeIndex];

            snakeIndex++;
        }
    }
}
