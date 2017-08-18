using System;

namespace Calculator
{
    class Calculator
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char operatorX = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (operatorX)
            {
                case '+':
                    Console.WriteLine($"{firstNumber} {operatorX} {secondNumber} = {firstNumber + secondNumber}");
                    break;
                case '-':
                    Console.WriteLine($"{firstNumber} {operatorX} {secondNumber} = {firstNumber - secondNumber}");
                    break;
                case '*':
                    Console.WriteLine($"{firstNumber} {operatorX} {secondNumber} = {firstNumber * secondNumber}");
                    break;
                case '/':
                    Console.WriteLine($"{firstNumber} {operatorX} {secondNumber} = {firstNumber / secondNumber}");
                    break;
            }
        }
    }
}
