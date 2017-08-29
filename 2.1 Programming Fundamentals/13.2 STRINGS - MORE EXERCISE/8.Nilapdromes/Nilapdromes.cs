using System;

namespace _8.Nilapdromes
{
    public class Nilapdromes
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var nilapdrome = ReturnNilapdrome(inputLine);

                if (nilapdrome != null) Console.WriteLine(nilapdrome);
                
                inputLine = Console.ReadLine();
            }
        }

        private static string ReturnNilapdrome(string inputLine)
        {
            var middleIndex = inputLine.Length / 2;

            var border = string.Empty;
            var leftIndex = 0;

            for (int i = middleIndex + 1; i < inputLine.Length; i++)
            {
                if (inputLine[leftIndex] == inputLine[i])
                {
                    border += inputLine[i];
                    leftIndex++;
                }
                else
                {
                    border = string.Empty;
                    leftIndex = 0;
                    if (inputLine[leftIndex] == inputLine[i])
                    {
                        border += inputLine[i];
                        leftIndex++;
                    }
                }
            }

            if (border != string.Empty)
            {
                var leftIndexMiddle = inputLine.IndexOf(border);
                var rightIndexMiddle = inputLine.LastIndexOf(border);

                var middleSubstring = inputLine.Substring(leftIndexMiddle + border.Length, rightIndexMiddle - border.Length);

                return middleSubstring + border + middleSubstring;
            }

            return null;
        }
    }
}
