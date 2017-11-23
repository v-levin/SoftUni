using System;

namespace _3.ParseTags
{
    public class ParseTags
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var openTag = "<upcase>";
            var closeTag = "</upcase>";

            var startIndex = text.IndexOf(openTag);
            while (startIndex != -1)
            {
                var endIndex = text.IndexOf(closeTag);

                if (endIndex == -1)
                {
                    break;
                }

                var toBeReplaced = text.Substring(startIndex, endIndex + closeTag.Length - startIndex);
                var upperCase = toBeReplaced.Replace(openTag, string.Empty).Replace(closeTag, string.Empty).ToUpper();

                text = text.Replace(toBeReplaced, upperCase);

                startIndex = text.IndexOf(openTag);
            }

            Console.WriteLine(text);
        }
    }
}
