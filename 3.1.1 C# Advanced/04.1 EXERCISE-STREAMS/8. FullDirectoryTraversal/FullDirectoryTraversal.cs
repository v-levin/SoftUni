using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

public class FullDirectoryTraversal
{
    public static void Main()
    {
        // read directory
        var dir = ReadDirectory();

        // get and store file info about all files in the current directory
        string[] filePaths = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);

        var files = filePaths.Select(path => new FileInfo(path)).ToList();

        // sort file info
        var sorted = files.OrderBy(file => file.Length).GroupBy(file => file.Extension).OrderByDescending(group => group.Count()).ThenBy(group => group.Key);

        // locate desktop
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // create report file
        using (var writer = new StreamWriter(desktop + "/report.txt"))
        {
            foreach (var groups in sorted)
            {
                writer.WriteLine(groups.Key);

                foreach (var group in groups)
                {
                    writer.WriteLine($"--{group.Name} - {group.Length / 1024.0:F3}kb");
                }
            }
        }

        // open report file
        Process.Start(desktop + "/report.txt");
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