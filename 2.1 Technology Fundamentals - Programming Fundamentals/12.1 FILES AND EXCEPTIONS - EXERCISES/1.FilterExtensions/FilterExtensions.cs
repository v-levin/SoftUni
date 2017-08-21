using System;
using System.Collections.Generic;
using System.IO;

namespace _1.FilterExtensions
{
    public class FilterExtensions
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var files = new List<string>();
            
            try
            {
                var directoryFiles = Directory.GetFiles("../../input");

                foreach (var file in directoryFiles)
                {
                    var fileInfo = new FileInfo(file);

                    var fileExtension = fileInfo.Extension;

                    if ($".{inputLine}" == fileExtension)
                    {
                        files.Add(fileInfo.Name);
                    }
                }

                File.WriteAllLines("../../output.txt", files);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory does not exists!");
            }
        }
    }
}
