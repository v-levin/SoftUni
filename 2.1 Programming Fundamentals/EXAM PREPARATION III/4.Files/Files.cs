using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Files
{
    public class Files
    {
        public static void Main()
        {
            // ROOT -> FILENAME : FILESIZE
            var filesByRoot = new Dictionary<string, Dictionary<string, long>>();

            var numberOfFiles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfFiles; i++)
            {
                var inputLine = Console.ReadLine();

                var inputParams = inputLine.Split('\\');

                var root = inputParams[0];
                var fileParams = inputParams[inputParams.Length - 1].Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                var fileName = fileParams[0];
                var fileSize = long.Parse(fileParams[1]);

                if (!filesByRoot.ContainsKey(root))
                {
                    filesByRoot[root] = new Dictionary<string, long>();
                }

                filesByRoot[root][fileName] = fileSize;

            }

            var queryString = Console.ReadLine().Split();
            var extension = queryString[0];
            var queryRoot = queryString[2];

            var orderedFiles = new Dictionary<string, long>();
            
            foreach (var file in filesByRoot)
            {
                var fileRoot = file.Key;
                var fileNames = file.Value.Keys;

                if (queryRoot == fileRoot)
                {
                    foreach (var fileName in file.Value.OrderByDescending(f => f.Value).ThenBy(f => f.Key))
                    {
                        var fileExtension = fileName.Key.Split('.').Last();
                        var fileSize = fileName.Value;

                        if (extension == fileExtension)
                        {
                            orderedFiles.Add(fileName.Key, fileSize);
                        }
                    }
                }
            }

            if (orderedFiles.Any())
            {
                foreach (var file in orderedFiles)
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
