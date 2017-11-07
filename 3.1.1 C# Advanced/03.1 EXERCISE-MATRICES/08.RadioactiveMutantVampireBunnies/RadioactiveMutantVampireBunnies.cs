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
            var result = "won";

            while (playerInGame)
            {
                foreach (var direction in directions)
                {
                    FindPlayer(matrix, playerPosition);
                    MovePlayer(matrix, direction, ref playerInGame, ref result, playerPosition);
                    SpreadTheBunnies(matrix, ref playerInGame, ref result);

                    if (result == "dead")
                    {
                        break;
                    }
                }
            }

            foreach (var elements in matrix)
            {
                Console.WriteLine(string.Join("", elements));
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
            var row = playerPosition[0];
            var col = playerPosition[1];

            switch (direction)
            {
                case 'U':
                    if (row - 1 >= 0)
                    {
                        playerPosition[0] = row - 1;
                        playerPosition[1] = col;

                        if (matrix[row - 1][col] == 'B')
                        {
                            matrix[row][col] = '.';
                            playerInGame = false;
                            result = "dead";
                            return;
                        }

                        matrix[row - 1][col] = 'P';
                        matrix[row][col] = '.';
                    }
                    else
                    {
                        matrix[row][col] = '.';
                        playerPosition[0] = row;
                        playerPosition[1] = col;
                        playerInGame = false;
                        return;
                    }
                    break;

                case 'D':
                    if (row + 1 <= matrix.Length - 1)
                    {
                        playerPosition[0] = row + 1;
                        playerPosition[1] = col;

                        if (matrix[row + 1][col] == 'B')
                        {
                            matrix[row][col] = '.';
                            playerInGame = false;
                            result = "dead";
                            return;
                        }

                        matrix[row + 1][col] = 'P';
                        matrix[row][col] = '.';
                    }
                    else
                    {
                        matrix[row][col] = '.';
                        playerPosition[0] = row;
                        playerPosition[1] = col;
                        playerInGame = false;
                        return;
                    }
                    break;

                case 'L':
                    if (col - 1 >= 0)
                    {
                        playerPosition[0] = row;
                        playerPosition[1] = col - 1;

                        if (matrix[row][col - 1] == 'B')
                        {
                            matrix[row][col] = '.';
                            playerInGame = false;
                            result = "dead";
                            return;
                        }

                        matrix[row][col - 1] = 'P';
                        matrix[row][col] = '.';
                    }
                    else
                    {
                        matrix[row][col] = '.';
                        playerPosition[0] = row;
                        playerPosition[1] = col;
                        playerInGame = false;
                        return;
                    }
                    break;

                case 'R':
                    if (col + 1 <= matrix[row].Length - 1)
                    {
                        playerPosition[0] = row;
                        playerPosition[1] = col + 1;

                        if (matrix[row][col + 1] == 'B')
                        {
                            matrix[row][col] = '.';
                            playerInGame = false;
                            result = "dead";
                            return;
                        }

                        matrix[row][col + 1] = 'P';
                        matrix[row][col] = '.';
                    }
                    else
                    {
                        matrix[row][col] = '.';
                        playerPosition[0] = row;
                        playerPosition[1] = col;
                        playerInGame = false;
                        return;
                    }
                    break;
            }
        }


        private static void SpreadTheBunnies(char[][] matrix, ref bool playerInGame, ref string result)
        {
            var bunniesIndexes = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'B')
                    {
                        bunniesIndexes.Add(new KeyValuePair<int, int>(i, j));
                    }
                }
            }

            foreach (var bunnieIndex in bunniesIndexes)
            {
                var row = bunnieIndex.Key;
                var col = bunnieIndex.Value;

                if (row - 1 >= 0)
                {
                    if (matrix[row - 1][col] == 'P')
                    {
                        matrix[row - 1][col] = 'B';
                        playerInGame = false;
                        result = "dead";
                        return;
                    }

                    matrix[row - 1][col] = 'B';
                }

                if (row + 1 <= matrix.Length - 1)
                {
                    if (matrix[row + 1][col] == 'P')
                    {
                        matrix[row + 1][col] = 'B';
                        playerInGame = false;
                        result = "dead";
                        return;
                    }

                    matrix[row + 1][col] = 'B';
                }

                if (col - 1 >= 0)
                {
                    if (matrix[row][col - 1] == 'P')
                    {
                        matrix[row][col - 1] = 'B';
                        playerInGame = false;
                        result = "dead";
                        return;
                    }

                    matrix[row][col - 1] = 'B';
                }

                if (col + 1 <= matrix[row].Length - 1)
                {
                    if (matrix[row][col + 1] == 'P')
                    {
                        matrix[row][col + 1] = 'B';
                        playerInGame = false;
                        result = "dead";
                        return;
                    }

                    matrix[row][col + 1] = 'B';
                }
            }
        }
    }
}
