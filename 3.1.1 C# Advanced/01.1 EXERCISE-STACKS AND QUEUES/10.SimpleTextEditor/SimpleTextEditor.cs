using System;
using System.Collections.Generic;

namespace _10.SimpleTextEditor
{
    public class SimpleTextEditor
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var stringStack = new Stack<string>();
            var text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = inputParams[0];

                switch (command)
                {
                    case "1":
                        var stringToAppend = inputParams[1];
                        stringStack.Push(text);
                        text += stringToAppend;
                        break;

                    case "2":
                        var elementsToErase = int.Parse(inputParams[1]);
                        stringStack.Push(text);
                        text = text.Substring(0, text.Length - elementsToErase);
                        break;

                    case "3":
                        var index = int.Parse(inputParams[1]);
                        Console.WriteLine(text[index - 1]);
                        break;

                    case "4":
                        text = stringStack.Pop();
                        break;
                }
            }
        }
    }
}
