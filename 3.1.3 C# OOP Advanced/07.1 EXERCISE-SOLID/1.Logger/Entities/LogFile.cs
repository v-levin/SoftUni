using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _Logger.Entities
{
    public class LogFile
    {
        private const string DefaultFileName = "log.txt";

        private readonly StringBuilder stringBuilder;

        public LogFile()
        {
            this.stringBuilder = new StringBuilder();
        }

        public int Size { get; private set; }

        public void Write(string message)
        {
            this.stringBuilder.AppendLine(message);
            File.AppendAllText(DefaultFileName, message + Environment.NewLine);
            this.Size += GetLettersOnlySum(message);
        }

        private int GetLettersOnlySum(string message)
        {
            return message
                .Where(c => char.IsLetter(c))
                .Sum(c => c);
        }
    }
}
