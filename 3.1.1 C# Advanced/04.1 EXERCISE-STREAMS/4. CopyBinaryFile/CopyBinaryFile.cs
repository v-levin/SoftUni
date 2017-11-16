using System.IO;

namespace _4.CopyBinaryFile
{
    public class CopyBinaryFile
    {
        const string SheepImagePath = "../../sheep.jpg";
        const string DestinationPath = "../../result.jpg";

        public static void Main()
        {
            using (var source = new FileStream(SheepImagePath, FileMode.Open))
            using (var destination = new FileStream(DestinationPath, FileMode.Create))
            {
                double fileLength = source.Length;
                var buffer = new byte[4096];
                while (true)
                {
                    var readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }

                    destination.Write(buffer, 0, readBytes);
                }
            }
        }
    }
}
