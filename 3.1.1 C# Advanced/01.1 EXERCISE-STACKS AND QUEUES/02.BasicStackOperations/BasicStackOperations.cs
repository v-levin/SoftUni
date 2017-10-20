using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicStackOperations
{
    public class BasicStackOperations
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var n = int.Parse(input[0]);
            var s = int.Parse(input[1]);
            var x = int.Parse(input[2]);

            var integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(integers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
