using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_November_02_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfDays = int.Parse(Console.ReadLine());
            var foodInKg = int.Parse(Console.ReadLine());
            var dogDailyFoodInKg = double.Parse(Console.ReadLine());
            var catDailyFoodInKg = double.Parse(Console.ReadLine());
            var turtleDailyFoodInGr = int.Parse(Console.ReadLine());

            var dogFood = numberOfDays * dogDailyFoodInKg;
            var catFood = numberOfDays * catDailyFoodInKg;
            var turtleFood = numberOfDays * turtleDailyFoodInGr / 1000.00;

            var totalFood = dogFood + catFood + turtleFood;

            if (totalFood <= foodInKg)
            {
                Console.WriteLine($"{Math.Floor(foodInKg - totalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood - foodInKg)} more kilos of food are needed.");
            }
        }
    }
}
