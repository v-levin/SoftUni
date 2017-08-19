using System;

namespace SumSeconds
{
    class Program
    {
        static void Main()
        {
            var firstSeconds = int.Parse(Console.ReadLine());
            var secondSeconds = int.Parse(Console.ReadLine());
            var thirdSeconds = int.Parse(Console.ReadLine());

            var totalSeconds = firstSeconds + secondSeconds + thirdSeconds;
            var minutes = totalSeconds / 60;
            var seconds = totalSeconds % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }

        }
    }
}