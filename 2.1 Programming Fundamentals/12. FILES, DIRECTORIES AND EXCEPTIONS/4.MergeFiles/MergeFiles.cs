using System;
using System.IO;

namespace _4.MergeFiles
{
    public class MergeFiles
    {
        public static void Main()
        {
            var fileOne = File.ReadAllLines("../../FileOne.txt");
            var fileTwo = File.ReadAllLines("../../FileTwo.txt");

            for (int i = 0; i < fileOne.Length; i++)
            {
                File.AppendAllText("../../output.txt", fileOne[i] + Environment.NewLine);
                File.AppendAllText("../../output.txt", fileTwo[i] + Environment.NewLine);
            }
        }
    }
}
