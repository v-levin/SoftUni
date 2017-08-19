using System;

namespace _5_IntegerToBase
{
    class IntegerToBase_
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            string converted = IntegerToBase(number, toBase);

            Console.WriteLine(converted);
        }

        static string IntegerToBase(long number, int toBase)
        {
            string result = string.Empty;

            while (number > 0)
            {
                var remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }

            return result;
        }
    }
}
