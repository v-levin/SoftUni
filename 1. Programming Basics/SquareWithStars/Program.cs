using System;

namespace SquareWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int col = 0; col < n; col++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("*" + new string(' ', n - 2) + "*");
                Console.WriteLine();
            }

            Console.WriteLine(new string('*', n));
        }
    }
}