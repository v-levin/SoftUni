﻿using System;

namespace TravelingAtLightSpeed
{
    class TravelingAtLightSpeed
    {
        static void Main()
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal kilometers = lightYears * 9450000000000;
            decimal speedOfLight = 300000;

            decimal seconds = kilometers / speedOfLight;

            decimal minutes = seconds / 60;
            seconds %= 60;
            decimal hours = minutes / 60;
            minutes %= 60;
            decimal days = hours / 24;
            hours %= 24;
            decimal weeks = days / 7;
            days %= 7;

            Console.WriteLine($"{(int)weeks} weeks");
            Console.WriteLine($"{(int)days} days");
            Console.WriteLine($"{(int)hours} hours");
            Console.WriteLine($"{(int)minutes} minutes");
            Console.WriteLine($"{(int)seconds} seconds");
        }
    }
}
