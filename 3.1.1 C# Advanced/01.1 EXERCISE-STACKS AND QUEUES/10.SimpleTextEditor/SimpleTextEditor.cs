using System;
using System.Collections.Generic;
using System.Text;

namespace _10.SimpleTextEditor
{
    public class SimpleTextEditor
    {
        public static void Main()
        {
            var text = new StringBuilder();
            var stringStack = new Stack<string>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = inputParams[0];

                switch (command)
                {
                    case "1":
                        var stringToAppend = inputParams[1];
                        stringStack.Push(text.ToString());
                        text.Append(stringToAppend);

                        break;

                    case "2":
                        var elementsToErase = int.Parse(inputParams[1]);

                        if (elementsToErase > text.Length)
                        {
                            text.Clear();
                            stringStack.Push(text.ToString());
                            break;
                        }

                        stringStack.Push(text.ToString());

                        text.Remove(text.Length - elementsToErase, elementsToErase);

                        break;

                    case "3":
                        var index = int.Parse(inputParams[1]);

                        if (text.Length >= index && index > 0)
                        {
                            Console.WriteLine(text[index - 1]);
                        }

                        break;

                    case "4":
                        text.Clear();
                        text.Append(stringStack.Pop());
                        break;
                }
            }
        }
    }
}
