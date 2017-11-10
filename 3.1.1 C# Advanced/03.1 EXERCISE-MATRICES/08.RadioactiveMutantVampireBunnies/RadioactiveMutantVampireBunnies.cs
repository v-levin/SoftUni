using System;
using System.Collections.Generic;

namespace _08.RadioactiveMutantVampireBunnies
{
    public class RadioactiveMutantVampireBunnies
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var rows = int.Parse(matrixSize[0]);
            var cols = int.Parse(matrixSize[1]);

            var matrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                var elements = Console.ReadLine().ToCharArray();
                matrix[i] = elements;
            }

            var directions = Console.ReadLine().ToCharArray();

            var playerPosition = new int[2];
            var playerInGame = true;
            var result = string.Empty;

            while (playerInGame)
            {
                foreach (var direction in directions)
                {
                    FindPlayer(matrix, playerPosition);
                    MovePlayer(matrix, direction, ref playerInGame, ref result, playerPosition);
                    SpreadTheBunnies(matrix, ref playerInGame, ref result);

                    if (result == "dead" || result == "won")
                    {
                        break;
                    }
                }
            }

            foreach (var elements in matrix)
            {
                Console.WriteLine(string.Join(string.Empty, elements));
            }

            Console.WriteLine($"{result}: {string.Join(" ", playerPosition)}");
        }
        

        private static void FindPlayer(char[][] matrix, int[] playerPosition)
        {

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'P')
                    {
                        playerPosition[0] = i;
                        playerPosition[1] = j;
                        return;
                    }
                }
            }
        }


        private static void MovePlayer(char[][] matrix, char direction, ref bool playerInGame, ref string result, int[] playerPosition)
        {
            var currentRow = playerPosition[0];
            var currentCol = playerPosition[1];
            var nextRow = 0;
            var nextCol = 0;

            switch (direction)
            {
                case 'U':
                    nextRow = currentRow - 1;
                    nextCol = currentCol;
                    break;

                case 'D':
                    nextRow = currentRow + 1;
                    nextCol = currentCol;
                    break;

                case 'L':
                    nextRow = currentRow;
                    nextCol = currentCol - 1;
                    break;

                case 'R':
                    nextRow = currentRow;
                    nextCol = currentCol + 1;
                    break;
            }

            if (IsPlayerInTheLayer(nextRow, nextCol, matrix))
            {
                playerPosition[0] = nextRow;
                playerPosition[1] = nextCol;

                if (matrix[nextRow][nextCol].Equals('.'))
                {
                    matrix[nextRow][nextCol] = 'P';
                    matrix[currentRow][currentCol] = '.';
                }
                else if (matrix[nextRow][nextCol].Equals('B'))
                {
                    playerInGame = false;
                    result = "dead";
                }
            }
            else
            {
                matrix[currentRow][currentCol] = '.';
                playerInGame = false;
                result = "won";
            }
        }

        private static bool IsPlayerInTheLayer(int row, int col, char[][] matrix)
        {
            if (row < 0 || col < 0 || row >= matrix.Length || col >= matrix[row].Length)
            {
                return false;
            }

            return true;
        }

        private static void SpreadTheBunnies(char[][] matrix, ref bool playerInGame, ref string result)
        {
            var bunniesIndexes = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j].Equals('B'))
                    {
                        bunniesIndexes.Add(new KeyValuePair<int, int>(i, j));
                    }
                }
            }

            foreach (var bunnieIndex in bunniesIndexes)
            {
                var row = bunnieIndex.Key;
                var col = bunnieIndex.Value;

                // UP
                if (matrix[Math.Max(row - 1, 0)][col].Equals('P'))
                {
                    playerInGame = false;
                    result = "dead";
                }
                // DOWN
                else if (matrix[Math.Min(row + 1, matrix.Length - 1)][col].Equals('P'))
                {
                    playerInGame = false;
                    result = "dead";
                }
                // LEFT
                else if (matrix[row][Math.Max(col - 1, 0)].Equals('P'))
                {
                    playerInGame = false;
                    result = "dead";
                }
                // RIGHT
                else if (matrix[row][Math.Min(col + 1, matrix[row].Length - 1)].Equals('P'))
                {
                    playerInGame = false;
                    result = "dead";
                }

                matrix[Math.Max(row - 1, 0)][col] = 'B';
                matrix[Math.Min(row + 1, matrix.Length - 1)][col] = 'B';
                matrix[row][Math.Max(col - 1, 0)] = 'B';
                matrix[row][Math.Min(col + 1, matrix[row].Length - 1)] = 'B';
            }
        }
    }
}
