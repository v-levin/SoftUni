﻿using System;

namespace _2_SignOfIntegerNumber
{
    class SignOfIntegerNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintSign(n);
        }

        public static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        } 
    }
}
