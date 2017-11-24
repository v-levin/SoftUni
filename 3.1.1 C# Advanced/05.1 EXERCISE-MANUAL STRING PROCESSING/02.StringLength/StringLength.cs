using System;

namespace _02.StringLength
{
    public class StringLength
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var maxChars = 20;

            if (text.Length > maxChars)
            {
                text = text.Substring(0, maxChars);
            }
            else if (text.Length < maxChars)
            {
                text = string.Concat(text, new string('*', maxChars - text.Length));
            }

            Console.WriteLine(text);
        }
    }
}
