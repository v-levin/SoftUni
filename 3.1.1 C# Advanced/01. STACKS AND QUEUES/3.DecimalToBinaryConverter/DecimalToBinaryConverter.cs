using System;
using System.Collections.Generic;

namespace _3.DecimalToBinaryConverter
{
    public class DecimalToBinaryConverter
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            if (number == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (number != 0)
                {
                    var reminder = number % 2;

                    stack.Push(reminder);

                    number /= 2;
                }
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}
