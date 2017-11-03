using System;

namespace _4.PascalTriangle
{
    public class PascalTriangle
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var pascalTriangle = new long[n][];

            for (int row = 0; row < n; row++)
            {
                pascalTriangle[row] = new long[row + 1];
                pascalTriangle[row][0] = 1;
                pascalTriangle[row][row] = 1;

                for (int col = 1; col < pascalTriangle[row].Length - 1; col++)
                {
                    pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                }

                Console.WriteLine(string.Join(" ", pascalTriangle[row]));
            }
        }
    }
}
