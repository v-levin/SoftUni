using System;
using System.Collections.Generic;

namespace _01.ReverseNumbersWithAStack
{
    public class ReverseNumbersWithAStack
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                var number = 0;
                if (int.TryParse(input[i], out number))
                {
                    stack.Push(number);
                }
            }

            while (stack.Count != 0)
            {
                Console.Write($"{stack.Pop()} ");
            }

            Console.WriteLine();
        }
    }
}
