using System;

namespace DataOverflow
{
    class DataOverflow
    {
        static void Main()
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            decimal firstNumberMaxValue = 0;
            decimal secondNumberMaxValue = 0;

            string firstNumberType = "";
            string secondNumberType = "";

            if (firstNumber >= byte.MinValue && firstNumber <= byte.MaxValue)
            {
                firstNumberType = "byte";
                firstNumberMaxValue = byte.MaxValue;
            }
            if (secondNumber >= byte.MinValue && secondNumber <= byte.MaxValue)
            {
                secondNumberType = "byte";
                secondNumberMaxValue = byte.MaxValue;
            }

            if (firstNumber > byte.MaxValue && firstNumber <= ushort.MaxValue)
            {
                firstNumberType = "ushort";
                firstNumberMaxValue = ushort.MaxValue;
            }
            if (secondNumber > byte.MaxValue && secondNumber <= ushort.MaxValue)
            {
                secondNumberType = "ushort";
                secondNumberMaxValue = ushort.MaxValue;
            }

            if (firstNumber > ushort.MaxValue && firstNumber <= uint.MaxValue)
            {
                firstNumberType = "uint";
                firstNumberMaxValue = uint.MaxValue;
            }
            if (secondNumber > ushort.MaxValue && secondNumber <= uint.MaxValue)
            {
                secondNumberType = "uint";
                secondNumberMaxValue = uint.MaxValue;
            }

            if (firstNumber > uint.MaxValue && firstNumber <= ulong.MaxValue)
            {
                firstNumberType = "ulong";
                firstNumberMaxValue = ulong.MaxValue;
            }
            if (secondNumber > uint.MaxValue && secondNumber <= ulong.MaxValue)
            {
                secondNumberType = "ulong";
                secondNumberMaxValue = ulong.MaxValue;
            }

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"bigger type: {firstNumberType}\nsmaller type: {secondNumberType}");
                Console.WriteLine($"{firstNumber} can overflow {secondNumberType} {Math.Round(firstNumber / secondNumberMaxValue)} times");
            }
            else
            {
                Console.WriteLine($"bigger type: {secondNumberType}\nsmaller type: {firstNumberType}");
                Console.WriteLine($"{secondNumber} can overflow {firstNumberType} {Math.Round(secondNumber / firstNumberMaxValue)} times");
            }
        }
    }
}
