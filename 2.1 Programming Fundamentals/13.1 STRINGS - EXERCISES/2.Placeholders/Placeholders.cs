using System;

namespace _2.Placeholders
{
    public class Placeholders
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var result = string.Empty;

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var sentence = inputParams[0];
                var elements = inputParams[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    var currentPlaceholder = "{" + i + "}";
                    sentence = sentence.Replace(currentPlaceholder, elements[i]);
                }

                Console.WriteLine(sentence);

                inputLine = Console.ReadLine();
            }
        }
    }
}
