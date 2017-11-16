using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3.WordCount
{
    public class WordCount
    {
        public static void Main()
        {
            var result = new Dictionary<string, int>();

            using (var wordReader = new StreamReader("../../words.txt"))
            {
                var word = string.Empty;
                while ((word = wordReader.ReadLine()) != null)
                {
                    word = word.ToLower();
                    result[word] = 0;

                    using (var textReader = new StreamReader("../../text.txt"))
                    {
                        var text = string.Empty;
                        while ((text = textReader.ReadLine()) != null)
                        {
                            var wordsInLine = text.ToLower().Split(new[] { ' ', '-', '?', '!', '.', ',', ':', '\'', '"', ';' }, StringSplitOptions.RemoveEmptyEntries);

                            foreach (var wordInLine in wordsInLine)
                            {
                                if (word == wordInLine)
                                {
                                    result[word]++;
                                }
                            }
                        }
                    }
                }
            }

            using (var writer = new StreamWriter("../../result.txt"))
            {
                foreach (var word in result.OrderByDescending(w => w.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
