using System;

namespace _6_MathPower
{
    class MathPower
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double numberRaisedToPower = RaiseToPower(number, power);

            Console.WriteLine(numberRaisedToPower);
        }

        static double RaiseToPower(double num, int pow)
        {
            double result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }

            return result;
        }
    }
}
