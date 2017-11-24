using System;
using System.Numerics;

namespace _05.ConvertFromBaseNToBase10
{
    public class ConvertFromBaseNToBase10
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine().Split();
            var baseN = int.Parse(inputNums[0]);
            var number = BigInteger.Parse(inputNums[1]);

            var result = ConvertFromBaseNTo10(number, baseN);

            Console.WriteLine(result);
        }

        private static BigInteger ConvertFromBaseNTo10(BigInteger number, int baseN)
        {
            var result = new BigInteger(0);
            var numAsString = number.ToString();

            for (int i = 0; i < numAsString.Length; i++)
            {
                var num = int.Parse(numAsString[numAsString.Length - 1 - i].ToString());
                result += num * BigInteger.Pow(baseN, i);
            }

            return result;
        }
    }
}
