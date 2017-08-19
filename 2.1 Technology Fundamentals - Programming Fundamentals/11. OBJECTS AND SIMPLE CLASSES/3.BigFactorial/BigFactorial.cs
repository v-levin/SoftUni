using System;
using System.Numerics;

namespace _3.BigFactorial
{
    public class BigFactorial
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = number; i > 1; i--)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
