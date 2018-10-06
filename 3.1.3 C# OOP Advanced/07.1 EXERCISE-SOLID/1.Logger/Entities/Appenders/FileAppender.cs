using _Logger.Enums;
using _Logger.Interfaces;
using System;
using System.Text;

namespace _Logger.Entities.Appenders
{
    public class FileAppender : IAppender
    {
        public FileAppender(ILayout layout)
        {
            this.Layout = layout;
            this.File = new LogFile();
        }

        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        public LogFile File { get; set; }

        public int Count { get; set; }

        public void Append(string timeStamp, string reportLevel, string message)
        {
            var formattedMsg = this.Layout.FormatMessage(timeStamp, reportLevel, message);
            this.File.Write(formattedMsg);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            return sb.Append($"Appender type: {this.GetType().Name}, ")
                .Append($"Layout type: {this.Layout.GetType().Name}, ")
                .Append($"Report level: {this.ReportLevel}, ")
                .Append($"Messages appended: {this.Count}, ")
                .Append($"File size: {this.File.Size}")
                .ToString();
        }
    }
}
