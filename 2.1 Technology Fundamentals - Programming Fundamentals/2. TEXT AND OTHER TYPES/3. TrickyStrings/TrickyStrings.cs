using System;

namespace TrickyStrings
{
    class TrickyStrings
    {
        static void Main()
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string strings = Console.ReadLine();
                text += strings + delimiter;
            }

            text = text.Substring(0, text.Length - delimiter.Length);

            Console.WriteLine(text);
        }
    }
}
