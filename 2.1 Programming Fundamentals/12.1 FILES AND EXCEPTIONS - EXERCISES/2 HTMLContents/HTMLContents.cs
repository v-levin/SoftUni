using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _2_HTMLContents
{
    public class HTMLContents
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var title = string.Empty;
            var bodyParts = new List<string>();

            while (inputLine != "exit")
            {
                var inputParams = inputLine.Split();
                var tag = inputParams[0];
                var tagContent = inputParams[1];

                if (tag == "title")
                {
                    title = tagContent;
                }
                else
                {
                    bodyParts.Add($"\t<{tag}>{tagContent}</{tag}>");
                }

                inputLine = Console.ReadLine();
            }

            var result = new StringBuilder();

            result.AppendLine("<!DOCTYPE html>");
            result.AppendLine("<html>");
            result.AppendLine("<head>");

            if (title != string.Empty)
            {
                result.AppendLine($"\t<title>{title}</title>");
            }

            result.AppendLine("</head>");
            result.AppendLine("<body>");

            if (bodyParts.Any())
            {
                result.AppendLine(string.Join(Environment.NewLine, bodyParts));
            }

            result.AppendLine("</body>");
            result.AppendLine("</html>");

            File.WriteAllText("../../index.html", result.ToString().Trim());
        }
    }
}
