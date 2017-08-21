using System;
using System.IO;

namespace _1.OddLines
{
    public class OddLines
    {
        public static void Main()
        {
            var fileLines = File.ReadAllLines("../../input.txt");

            for (int i = 1; i < fileLines.Length; i += 2)
            {
                File.AppendAllText("../../output.txt", fileLines[i] + Environment.NewLine);
            }
        }
    }
}
