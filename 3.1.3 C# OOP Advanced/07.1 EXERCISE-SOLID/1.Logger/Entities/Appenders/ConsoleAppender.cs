using _Logger.Enums;
using _Logger.Interfaces;
using System;
using System.Text;

namespace _Logger.Entities.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        public int Count { get; set; }

        public void Append(string timeStamp, string reportLevel, string message)
        {
            var formattedMsg = this.Layout.FormatMessage(timeStamp, reportLevel, message);
            Console.WriteLine(formattedMsg);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            return sb.Append($"Appender type: {this.GetType().Name}, ")
                .Append($"Layout type: {this.Layout.GetType().Name}, ")
                .Append($"Report level: {this.ReportLevel}, ")
                .Append($"Messages appended: {this.Count}")
                .ToString();
        }
    }
}
