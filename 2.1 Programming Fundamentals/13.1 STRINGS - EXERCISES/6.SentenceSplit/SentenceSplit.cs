using System;

namespace _6.SentenceSplit
{
    public class SentenceSplit
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var delimiters = Console.ReadLine();

            var splitedSentence = inputLine.Split(new string[] { delimiters }, StringSplitOptions.None);
            
            Console.WriteLine($"[{string.Join(", ", splitedSentence)}]");
        }
    }
}
