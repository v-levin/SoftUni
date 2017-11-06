using System;
using System.Linq;

namespace _07.LegoBlocks
{
    public class LegoBlocks
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var firstJaggedArr = GetMatrix(n);
            var secondJaggedArr = GetMatrix(n).Select(r => r.Reverse().ToArray()).ToArray();

            bool isRectangularMatrix = IsRectangularMatrix(n, firstJaggedArr, secondJaggedArr);

            PrintResult(n, firstJaggedArr, secondJaggedArr, isRectangularMatrix);

        }

        private static int[][] GetMatrix(int n)
        {
            var matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[i] = elements;
            }

            return matrix;
        }

        private static bool IsRectangularMatrix(int n, int[][] firstJaggedArr, int[][] secondJaggedArr)
        {
            for (int i = 1; i < n; i++)
            {
                if (firstJaggedArr[i - 1].Length + secondJaggedArr[i - 1].Length != firstJaggedArr[i].Length + secondJaggedArr[i].Length)
                {
                    return false;
                }
            }

            return true;
        }

        private static void PrintResult(int n, int[][] firstJaggedArr, int[][] secondJaggedArr, bool isRectangularMatrix)
        {
            if (isRectangularMatrix)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"[{string.Join(", ", firstJaggedArr[i])}, {string.Join(", ", secondJaggedArr[i])}]");
                }
            }
            else
            {
                var totalNumberOfCells = 0;
                for (int i = 0; i < n; i++)
                {
                    totalNumberOfCells += firstJaggedArr[i].Length + secondJaggedArr[i].Length;
                }

                Console.WriteLine($"The total number of cells is: {totalNumberOfCells}");
            }
        }
    }
}
