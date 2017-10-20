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
            var maxValue = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var type = input[0];

                switch (type)
                {
                    case 1:
                        var number = input[1];
                        numbers.Push(number);

                        if (maxValue < number)
                        {
                            maxValue = number;
                            maxNumbers.Push(maxValue);
                        }

                        break;
                    case 2:
                        if (numbers.Pop() == maxValue)
                        {
                            maxNumbers.Pop();

                            if (maxNumbers.Count != 0)
                            {
                                maxValue = maxNumbers.Peek();
                            }
                            else
                            {
                                maxValue = int.MinValue;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine(maxValue);
                        break;
                }
            }
        }
    }
}
