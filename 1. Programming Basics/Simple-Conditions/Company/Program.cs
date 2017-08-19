using System;

namespace Company
{
    class Program
    {
        static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var overTimeWorkers = int.Parse(Console.ReadLine());

            double tenPercentTraining = (double)days / 10;
            double timeLeft = (days - tenPercentTraining) * 8;
            var overTime = overTimeWorkers * 2 * days;
            var totalHours = Math.Floor(timeLeft + overTime);

            if (totalHours >= hours)
            {
                Console.WriteLine($"Yes!{totalHours - hours} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hours - totalHours} hours needed.");
            }
        }
    }
}