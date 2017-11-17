using System;
using System.Collections.Generic;
using System.IO;

namespace _5.SlicingFile
{
    public class SlicingFile
    {
        public static void Main()
        {
            ChooseAction();
        }

        private static void ChooseAction()
        {
            Console.Write($"(1) - Slice the file or (2) - Assemble the files{Environment.NewLine}Choose an action: ");
            var input = Console.ReadLine();

            var action = 0;
            if (int.TryParse(input, out action))
            {
                switch (action)
                {
                    case 1:
                        Console.Write("Enter a path to a file: ");
                        var sourceFile = Console.ReadLine();
                        var dir = string.Empty;
                        if (File.Exists(sourceFile))
                        {
                            dir = sourceFile.Substring(0, sourceFile.LastIndexOf('/'));
                        }
                        else
                        {
                            Console.WriteLine("File does not exist!");
                            ChooseAction();
                        }

                        Console.Write("Enter parts: ");

                        var parts = 0;
                        while (true)
                        {
                            try
                            {
                                parts = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Invalid input! Please try again.");
                            }
                        }

                        SliceFile(sourceFile, dir, parts);

                        break;
                    case 2:
                        AssembleFiles();

                        break;
                    default:
                        Console.WriteLine("Wrong input! Please try again.");
                        ChooseAction();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Wrong input! Please try again.");
                ChooseAction();
            }
        }

        private static void SliceFile(string sourceFile, string dir, int parts)
        {
            using (var reader = new FileStream(sourceFile, FileMode.Open))
            {
                var extension = sourceFile.Substring(sourceFile.LastIndexOf('.'));

                for (int i = 1; i <= parts; i++)
                {
                    var partSize = reader.Length / parts + reader.Length % parts;
                    var outputFile = dir + $"/File {i}" + extension;
                    using (var writer = new FileStream(outputFile, FileMode.Create))
                    {
                        var buffer = new byte[4096];

                        while (writer.Length < partSize)
                        {
                            var readBytes = reader.Read(buffer, 0, buffer.Length);

                            if (readBytes == 0)
                            {
                                break;
                            }

                            writer.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }

        private static void AssembleFiles()
        {
            Console.WriteLine("Enter files to assemble: ");
            var files = new List<string>();

            var fileToAssemble = "Random File";
            while (!string.IsNullOrEmpty(fileToAssemble = Console.ReadLine()))
            {
                if (File.Exists(fileToAssemble))
                {
                    files.Add(fileToAssemble);
                }
                else
                {
                    Console.WriteLine("File does not exist! Please try again.");
                }

                Console.WriteLine("Enter another file or press ENTER to Assemble");
            }

            var extension = files[0].Substring(files[0].LastIndexOf('.'));
            var dir = files[0].Substring(0, files[0].LastIndexOf('/'));
            var outputFile = $"{dir}/output" + extension;

            using (var writer = new FileStream(outputFile, FileMode.Create))
            {
                foreach (var file in files)
                {
                    using (var reader = new FileStream(file, FileMode.Open))
                    {
                        var buffer = new byte[4096];
                        var readBytes = reader.Read(buffer, 0, buffer.Length);

                        while (readBytes != 0)
                        {
                            writer.Write(buffer, 0, readBytes);
                            readBytes = reader.Read(buffer, 0, buffer.Length);
                        }

                    }
                }
            }
        }
    }
}
