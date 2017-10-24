using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumElement
{
    public class MaximumElement
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new Stack<int>();
            var maxNumbers = new Stack<int>();
            var maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var command = input[0];

                switch (command)
                {
                    case 1:
                        var numberToPush = input[1];
                        numbers.Push(numberToPush);

                        if (numberToPush >= maxNumber)
                        {
                            maxNumber = numberToPush;
                            maxNumbers.Push(numberToPush);
                        }

                        break;
                    case 2:
                        var elementAtTop = numbers.Pop();
                        var currentMaxNumber = maxNumbers.Peek();
                        if (elementAtTop == currentMaxNumber)
                        {
                            maxNumbers.Pop();

                            if (maxNumbers.Count != 0)
                            {
                                maxNumber = maxNumbers.Peek();
                            }
                            else
                            {
                                maxNumber = int.MinValue;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine(maxNumbers.Peek());
                        break;
                }
            }
        }
    }
}
