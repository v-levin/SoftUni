using System;
using System.Linq;

namespace _1.SumMatrixElements
{
    public class SumMatrixElements
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

            var sum = 0;

            foreach (var num in matrix)
            {
                sum += num.Sum();
            }
            
            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix[0].Length);
            Console.WriteLine(sum);
        }
    }
}
