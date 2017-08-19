using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLily
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var machinePrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());
            var money = 0;
            var toys = 0;
            var count = 0;

            for (int i = 0; i < age; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    count++;
                    money += count * 10;
                }
                else
                {
                    toys++;
                }
            }

            var totalSum = money + (toys * toyPrice) - count;

            if (totalSum >= machinePrice)
            {
                Console.WriteLine($"Yes! {totalSum - machinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {machinePrice - totalSum:f2}");
            }
        }
    }
}
