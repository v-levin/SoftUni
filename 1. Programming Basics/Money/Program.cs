using System;

namespace Money
{
    class Program
    {
        static void Main()
        {
            var bitcoins = int.Parse(Console.ReadLine());
            var yens = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine());

            var USD = yens * 0.15;
            var BGN = (bitcoins * 1168) + (USD * 1.76);
            var EUR = BGN / 1.95;
            var EURCommission = EUR * commission / 100;

            Console.WriteLine(EUR - EURCommission);

        }
    }
}