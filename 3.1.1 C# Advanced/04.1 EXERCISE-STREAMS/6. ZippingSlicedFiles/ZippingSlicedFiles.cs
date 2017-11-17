using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ZippingSlicedFiles
{
    public class ZippingSlicedFiles
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
                var partSize = reader.Length / parts + reader.Length % parts;

                for (int i = 1; i <= parts; i++)
                {
                    var outputFile = dir + $"/File {i}{extension}.gz";

                    using (var writer = new FileStream(outputFile, FileMode.Create))
                    {
                        using (var compressStream = new GZipStream(writer, CompressionMode.Compress, false))
                        {
                            var currentPieceSize = 0L;
                            var buffer = new byte[4096];

                            while (currentPieceSize < partSize)
                            {
                                var readBytes = reader.Read(buffer, 0, buffer.Length);

                                if (readBytes == 0)
                                {
                                    break;
                                }

                                compressStream.Write(buffer, 0, readBytes);
                                currentPieceSize += readBytes;
                            }
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
                var zipExtension = fileToAssemble.Substring(fileToAssemble.LastIndexOf('.'));

                if (zipExtension == ".gz" && File.Exists(fileToAssemble))
                {
                    files.Add(fileToAssemble);
                }
                else
                {
                    Console.WriteLine("File does not exist! Please try again.");
                }

                Console.WriteLine("Enter another file or press ENTER to Assemble");
            }

            var parts = files[0].Split('.');
            var extension = parts[parts.Length - 2];
            var dir = files[0].Substring(0, files[0].LastIndexOf('/'));
            var outputFile = $"{dir}/output.{extension}";

            using (var writer = new FileStream(outputFile, FileMode.Create))
            {
                foreach (var file in files)
                {
                    using (var reader = new FileStream(file, FileMode.Open))
                    {
                        using (var decmpressionStream = new GZipStream(reader, CompressionMode.Decompress, false))
                        {
                            var buffer = new byte[4096];
                            var readBytes = decmpressionStream.Read(buffer, 0, buffer.Length);

                            while (readBytes != 0)
                            {
                                writer.Write(buffer, 0, readBytes);
                                readBytes = decmpressionStream.Read(buffer, 0, buffer.Length);
                            }
                        }
                    }
                }
            }
        }
    }
}
