using System;
using System.Linq;

namespace _05.RubiksMatrix
{
    public class RubiksMatrix
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rows = matrixSize[0];
            var cols = matrixSize[1];

            var rubikMatrix = new int[rows][];

            GetFilledMatrix(cols, rubikMatrix);

            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commandParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var rowCol = int.Parse(commandParams[0]);
                var direction = commandParams[1];
                var moves = int.Parse(commandParams[2]);

                switch (direction)
                {
                    case "up":
                        ShiftMatrixCol(rubikMatrix, rowCol, moves);
                        break;
                    case "down":
                        ShiftMatrixCol(rubikMatrix, rowCol, rows - moves % rows);
                        break;
                    case "left":
                        ShiftMatrixRow(rubikMatrix, rowCol, moves);
                        break;
                    case "right":
                        ShiftMatrixRow(rubikMatrix, rowCol, cols - moves % cols);
                        break;
                }
            }

            PrintResult(rubikMatrix);
        }

        private static void PrintResult(int[][] rubikMatrix)
        {
            var element = 1;
            for (int i = 0; i < rubikMatrix.Length; i++)
            {
                for (int j = 0; j < rubikMatrix[i].Length; j++)
                {
                    if (rubikMatrix[i][j] == element)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int k = i; k < rubikMatrix.Length; k++)
                        {
                            for (int l = 0; l < rubikMatrix[i].Length; l++)
                            {
                                if (rubikMatrix[k][l] == element)
                                {
                                    var currentElement = rubikMatrix[i][j];
                                    rubikMatrix[i][j] = element;
                                    rubikMatrix[k][l] = currentElement;
                                    Console.WriteLine($"Swap ({i}, {j}) with ({k}, {l})");
                                    break;
                                }
                            }
                        }
                    }

                    element++;
                }
            }
        }

        private static void ShiftMatrixRow(int[][] rubikMatrix, int rowCol, int moves)
        {
            var temp = new int[rubikMatrix[0].Length];

            for (int i = 0; i < rubikMatrix[0].Length; i++)
            {
                temp[i] = rubikMatrix[rowCol][(i + moves) % rubikMatrix[0].Length];
            }
            
            rubikMatrix[rowCol] = temp;
        }

        private static void ShiftMatrixCol(int[][] rubikMatrix, int rowCol, int moves)
        {
            var temp = new int[rubikMatrix.Length];

            for (int i = 0; i < rubikMatrix.Length; i++)
            {
                temp[i] = rubikMatrix[(i + moves) % rubikMatrix.Length][rowCol];
            }

            for (int i = 0; i < rubikMatrix.Length; i++)
            {
                rubikMatrix[i][rowCol] = temp[i];
            }
        }

        private static void GetFilledMatrix(int cols, int[][] rubikMatrix)
        {
            var integer = 1;
            for (int i = 0; i < rubikMatrix.Length; i++)
            {
                rubikMatrix[i] = new int[cols];

                for (int j = 0; j < rubikMatrix[i].Length; j++)
                {
                    rubikMatrix[i][j] = integer;
                    integer++;
                }
            }
        }
    }
}
