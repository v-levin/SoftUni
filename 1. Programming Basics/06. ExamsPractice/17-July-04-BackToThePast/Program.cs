using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_July_04_BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var yearEnd = int.Parse(Console.ReadLine());
            var yearStart = 1800;
            var years = 18;

            for (int i = yearStart; i <= yearEnd; i++)
            {
                if (i % 2 == 0)
                {
                    var spend = 12000;
                    money -= spend;
                    years++;
                }
                else
                {
                    var spend = 12000 + years * 50;
                    money -= spend;
                    years++;
                }
            }

            if (money >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
            }
        }
    }
}
