using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SimpleCalculator
{
    public class SimpleCalculator
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var inputParams = input.Split(' ');
            var stack = new Stack<string>(inputParams.Reverse());

            while (stack.Count > 1)
            {
                var firstNumber = int.Parse(stack.Pop());
                var op = stack.Pop();
                var secondNumber = int.Parse(stack.Pop());

                if (op == "+")
                {
                    stack.Push((firstNumber + secondNumber).ToString());
                }
                else
                {
                    stack.Push((firstNumber - secondNumber).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
