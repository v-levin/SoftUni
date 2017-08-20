using System;
using System.IO;

namespace _2.LineNumbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            var inputLines = File.ReadAllLines("../../input.txt");

            for (int i = 0; i < inputLines.Length; i++)
            {
                File.AppendAllText("../../output.txt", $"{i + 1}. {inputLines[i]}{Environment.NewLine}");
            }
        }
    }
}
