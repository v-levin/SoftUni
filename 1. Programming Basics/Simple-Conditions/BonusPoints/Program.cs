﻿using System;

namespace BonusPoints
{
    class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var bonusPoints = 0.0;

            if (num <= 100)
            {
                bonusPoints += 5;
            }
            else if (num > 100 && num <= 1000)
            {
                bonusPoints = num * 0.2;
            }
            else if (num > 1000)
            {
                bonusPoints = num * 0.1;
            }

            if (num % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (num % 10 == 5)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(num + bonusPoints);
        }
    }
}