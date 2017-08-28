using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Pyramidic
{
    public class Pyramidic
    {
        public static void Main()
        {
            var lines = new List<string>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                lines.Add(Console.ReadLine());
            }

            var allPyramids = new List<string>();

            for (int i = 0; i < lines.Count; i++)
            {
                var line = lines[i];

                for (int j = 0; j < line.Length; j++)
                {
                    var @char = line[j];
                    var pyramid = FindPyramid(@char, lines, i);

                    allPyramids.Add(pyramid);
                }
            }

            var biggestPyramid = allPyramids.OrderByDescending(p => p.Length).First();

            Console.WriteLine(biggestPyramid.Trim());
        }

        private static string FindPyramid(char @char, List<string> lines, int lineNumebr)
        {
            var count = 3;
            var pyramid = @char + Environment.NewLine;

            for (int i = lineNumebr + 1; i < lines.Count; i++)
            {
                var toFind = new string(@char, count);

                if (lines[i].Contains(toFind))
                {
                    pyramid += toFind + Environment.NewLine;
                    count += 2;
                }
                else
                {
                    return pyramid;
                }
            }

            return pyramid;
        }
    }
}
