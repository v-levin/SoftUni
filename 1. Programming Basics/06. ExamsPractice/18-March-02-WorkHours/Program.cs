using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_March_02_WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var numberOfWorkers = int.Parse(Console.ReadLine());
            var workingDays = int.Parse(Console.ReadLine());

            var hours = numberOfWorkers * workingDays * 8;
            var hoursLeft = hours - hoursNeeded;

            if (hours >= hoursNeeded)
            {
                Console.WriteLine($"{hoursLeft} hours left");
            }
            else
            {
                var overTime = hoursNeeded - hours;
                var penalties = (hoursNeeded - hours) * workingDays;
                Console.WriteLine($"{overTime} overtime");
                Console.WriteLine($"Penalties: {penalties}");
            }
        }
    }
}
