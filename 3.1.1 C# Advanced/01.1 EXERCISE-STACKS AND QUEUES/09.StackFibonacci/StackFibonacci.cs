using System;
using System.Collections.Generic;

namespace _09.StackFibonacci
{
    public class StackFibonacci
    {
        public static void Main()
        {
            var fibonacciStack = new Stack<long>();

            var n = int.Parse(Console.ReadLine());

            fibonacciStack.Push(0);
            var firstNumber = fibonacciStack.Peek();
            fibonacciStack.Push(1);
            var secondNumber = fibonacciStack.Peek();

            for (int i = 0; i < n - 1; i++)
            {
                fibonacciStack.Push(firstNumber + secondNumber);

                firstNumber = secondNumber;
                secondNumber = fibonacciStack.Peek();
            }

            Console.WriteLine(fibonacciStack.Peek());
        }
    }
}
