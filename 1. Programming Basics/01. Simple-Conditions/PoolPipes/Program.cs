using System;

namespace PoolPipes
{
    class Program
    {
        static void Main()
        {
            var V = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            var H = double.Parse(Console.ReadLine());

            var firstPipe = P1 * H;
            var secondPipe = P2 * H;
            var bothPipes = firstPipe + secondPipe;

            if (bothPipes <= V)
            {
                var bothPipesPercentage = bothPipes / V * 100;
                var firstPipePercentage = firstPipe / bothPipes * 100;
                var secondPipePercentage = secondPipe / bothPipes * 100;

                Console.WriteLine($"The pool is {Math.Truncate(bothPipesPercentage)}% full. Pipe 1: {Math.Truncate(firstPipePercentage)}%. Pipe 2: {Math.Truncate(secondPipePercentage)}%.");
            }
            else if (bothPipes > V)
            {
                var overflows = bothPipes - V;

                Console.WriteLine($"For {H} hours the pool overflows with {overflows} liters.");
            }
        }
    }
}