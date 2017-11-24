using System;
using System.Numerics;

namespace _04.ConvertFrombase10TobaseN
{
    public class ConvertFrombase10TobaseN
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine().Split();
            var baseN = int.Parse(inputNums[0]);
            var base10 = BigInteger.Parse(inputNums[1]);

            var result = ConvertFromBase10ToBaseN(base10, baseN);

            Console.WriteLine(result);
        }

        private static string ConvertFromBase10ToBaseN(BigInteger base10, int baseN)
        {
            var result = string.Empty;

            while (base10 > 0)
            {
                var remainder = base10 % baseN;
                result = remainder + result;
                base10 /= baseN;
            }

            return result;
        }
    }
}
