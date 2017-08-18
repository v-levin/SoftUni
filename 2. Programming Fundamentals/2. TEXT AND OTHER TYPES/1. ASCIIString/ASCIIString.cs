using System;

namespace ASCIIString
{
    class ASCIIString
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                char character = (char) num;
                text += character;
            }
            Console.WriteLine(text);
        }
    }
}
