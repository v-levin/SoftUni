using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_November_04_SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfGroups = int.Parse(Console.ReadLine());
            var totalPeople = 0;
            var countCar = 0.0;
            var countMicroBus = 0.0;
            var countMiniBus = 0.0;
            var countBus = 0.0;
            var countTrain = 0.0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                var numberOfPeople = int.Parse(Console.ReadLine());

                if (numberOfPeople <= 5)
                {
                    countCar += numberOfPeople;
                }
                else if (numberOfPeople >= 6 && numberOfPeople <= 12)
                {
                    countMicroBus += numberOfPeople;
                }
                else if (numberOfPeople >= 13 && numberOfPeople <= 25)
                {
                    countMiniBus += numberOfPeople;
                }
                else if (numberOfPeople >= 26 && numberOfPeople <= 40)
                {
                    countBus += numberOfPeople;
                }
                else if (numberOfPeople > 40)
                {
                    countTrain += numberOfPeople;
                }

                totalPeople += numberOfPeople;
            }

            Console.WriteLine($"{countCar / totalPeople * 100:f2}%");
            Console.WriteLine($"{countMicroBus / totalPeople * 100:f2}%");
            Console.WriteLine($"{countMiniBus / totalPeople * 100:f2}%");
            Console.WriteLine($"{countBus / totalPeople * 100:f2}%");
            Console.WriteLine($"{countTrain / totalPeople * 100:f2}%");
        }
    }
}
