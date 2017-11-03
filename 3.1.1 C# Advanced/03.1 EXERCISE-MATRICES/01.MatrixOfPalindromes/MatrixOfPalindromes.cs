using System;

namespace _01.MatrixOfPalindromes
{
    public class MatrixOfPalindromes
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var rows = int.Parse(input[0]);
            var cols = int.Parse(input[1]);

            var matrixOfPalindromes = new string[rows][];

            var alphabet = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < rows; i++)
            {
                matrixOfPalindromes[i] = new string[cols];

                for (int j = i; j < cols + i; j++)
                {
                    matrixOfPalindromes[i][j - i] = $"{alphabet[i]}{alphabet[j]}{alphabet[i]}";
                }

                Console.WriteLine(string.Join(" ", matrixOfPalindromes[i]));
            }
        }
    }
}
