using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _7.DirectoryTraversal
{
    public class DirectoryTraversal
    {
        public static void Main()
        {
            var dir = ReadDirectory();
            var files = Directory.GetFiles(dir);
            var result = new Dictionary<string, Dictionary<string, long>>();

            foreach (var file in files)
            {
                var extension = Path.GetExtension(file);
                var fileSize = new FileInfo(file).Length;
                var fileName = file.Substring(file.LastIndexOf('\\') + 1);

                if (!result.ContainsKey(extension))
                {
                    result.Add(extension, new Dictionary<string, long>());
                }

                result[extension][fileName] = fileSize;
            }
            
            var output = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\report.txt";
            using (var writer = new StreamWriter(output))
            {
                foreach (var group in result.OrderByDescending(g => g.Value.Count).ThenBy(g => g.Key))
                {
                    var filesInGroup = string.Join(Environment.NewLine, group.Value.OrderBy(f => f.Value).Select(kvp => $"--{kvp.Key} - {kvp.Value}kb"));
                    writer.Write($"{group.Key}{Environment.NewLine}{filesInGroup}{Environment.NewLine}");
                }
            }
        }

        private static string ReadDirectory()
        {
            Console.Write("Choose directory to traverse: ");
            var dir = Console.ReadLine();

            if (!Directory.Exists(dir))
            {
                Console.WriteLine("Directory does not exist!");
                ReadDirectory();
            }

            return dir;
        }
    }
}
