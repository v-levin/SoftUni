using System;

namespace SleepyCatTom
{
    class Program
    {
        static void Main()
        {
            var numberOfRestDays = int.Parse(Console.ReadLine());

            var workingDays = 365 - numberOfRestDays;
            var timeForPlay = workingDays * 63 + numberOfRestDays * 127;
            
            if (timeForPlay < 30000)
            {
                var differenceNorm = 30000 - timeForPlay;
                var hours = differenceNorm / 60;
                var minutes = differenceNorm % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                var differenceNorm = timeForPlay - 30000;
                var hours = differenceNorm / 60;
                var minutes = differenceNorm % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}