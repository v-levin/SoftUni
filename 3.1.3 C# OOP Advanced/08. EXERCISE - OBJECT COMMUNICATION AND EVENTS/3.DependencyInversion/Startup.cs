using _3.DependencyInversion.Strategies;
using System;
using System.Collections.Generic;

namespace _3.DependencyInversion
{
    public class Startup
    {
        public static void Main()
        {
            Dictionary<char, IStrategy> _strategies = new Dictionary<char, IStrategy>()
            {
                { '+', new AdditionStrategy() },
                { '-', new SubtractionStrategy() },
                { '*', new MultiplyStrategy() },
                { '/', new DivideStrategy() }
            };

            var calculator = new PrimitiveCalculator(new AdditionStrategy(), _strategies);

            var input = Console.ReadLine().Split();
            while (input[0] != "End")
            {
                if (input[0] == "mode")
                    calculator.ChangeStrategy(char.Parse(input[1]));
                else
                    Console.WriteLine(calculator.PerformCalculation(int.Parse(input[0]), int.Parse(input[1])));
                
                input = Console.ReadLine().Split();
            }
        }
    }
}
