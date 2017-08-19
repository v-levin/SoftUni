using System;

namespace OperationBetweenTwoNumbers
{
    class Program
    {
        static void Main()
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var operation = Console.ReadLine();

            if (operation == "+")
            {
                var sum = num1 + num2;
                var even = sum % 2 == 0;
                if (even) Console.WriteLine($"{num1} + {num2} = {sum} - even");
                else Console.WriteLine($"{num1} + {num2} = {sum} - odd");
            }
            else if (operation == "-")
            {
                var subtract = num1 - num2;
                var even = subtract % 2 == 0;
                if (even) Console.WriteLine($"{num1} - {num2} = {subtract} - even");
                else Console.WriteLine($"{num1} - {num2} = {subtract} - odd");
            }
            else if (operation == "*")
            {
                var multiply = num1 * num2;
                var even = multiply % 2 == 0;
                if (even) Console.WriteLine($"{num1} * {num2} = {multiply} - even");
                else Console.WriteLine($"{num1} * {num2} = {multiply} - odd");
            }
            else if (operation == "/" && num2 != 0)
            {
                var devide = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {devide:f2}");
            }
            else if (operation == "%" && num2 != 0)
            {
                var module = num1 % num2;
                Console.WriteLine($"{num1} % {num2} = {module}");
            }
            else if (operation == "/" && num2 == 0 || operation == "%" && num2 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }

        }
    }
}