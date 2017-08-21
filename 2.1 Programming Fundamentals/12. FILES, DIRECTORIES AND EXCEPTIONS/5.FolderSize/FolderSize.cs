using System;
using System.IO;

namespace _5.FolderSize
{
    public class FolderSize
    {
        public static void Main()
        {
            var fileNames = Directory.GetFiles("../../TestFolder");

            double sumSize = 0;

            foreach (var file in fileNames)
            {
                var fileInfo = new FileInfo(file);
                sumSize += fileInfo.Length;
            }

            File.WriteAllText("../../output.txt", (sumSize / 1024 / 1024).ToString());
        }
    }
}
