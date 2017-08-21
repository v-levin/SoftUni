using System.Collections.Generic;
using System.IO;

namespace _4.Re_Directory
{
    public class ReDirectory
    {
        public static void Main()
        {
            var files = Directory.GetFiles("../../input");

            var groupOfFiles = new Dictionary<string, List<string>>();

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                var fileName = fileInfo.Name;
                var fileExtension = fileInfo.Extension.Replace(".", "");
                var folderName = $"{fileExtension}s";
                
                if (!groupOfFiles.ContainsKey(folderName))
                {
                    groupOfFiles[folderName] = new List<string>();
                }

                groupOfFiles[folderName].Add(fileName);
            }

            Directory.CreateDirectory("../../output");

            foreach (var folder in groupOfFiles)
            {
                var folderName = folder.Key;
                var filesGroup = folder.Value;

                Directory.CreateDirectory($"../../output/{folderName}");

                foreach (var file in filesGroup)
                {
                    File.Create($"../../output/{folderName}/{file}");
                }
            }
        }
    }
}
