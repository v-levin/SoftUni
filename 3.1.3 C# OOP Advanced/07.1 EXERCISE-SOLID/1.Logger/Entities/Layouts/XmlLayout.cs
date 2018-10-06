using _Logger.Interfaces;
using System.Text;

namespace _Logger.Entities.Layouts
{
    public class XmlLayout : ILayout
    {
        public string FormatMessage(string timeStamp, string reportLevel, string message)
        {
            var msg = new StringBuilder();

            return msg.AppendLine("<log>")
                .AppendLine($"   <date>{timeStamp}</date>")
                .AppendLine($"   <level>{reportLevel}</level>")
                .AppendLine($"   <message>{message}</message>")
                .Append("</log>")
                .ToString();
        }
    }
}
