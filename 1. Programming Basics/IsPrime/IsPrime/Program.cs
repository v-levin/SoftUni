using System;
using System.Collections.Generic;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeStart = DateTime.Now;
            var list = FindPrimes(0, 20);
            foreach (var prime in list)
            {
                Console.WriteLine(prime);
            }
            Console.WriteLine(DateTime.Now - timeStart);
        }

        static List<int> FindPrimes(int start, int end)
        {
            var primesList = new List<int>();

            for (int num = start; num <= end; num++)
            {
                bool prime = true;
                var maxDivider = Math.Sqrt(num);
                for (int divider = 2; divider <= maxDivider; divider++)
                {
                    if (num % divider == 0)
                    {
                        prime = false;
                    }
                }
                if (prime)
                {
                    primesList.Add(num);
                }
            }

            return primesList;
        }
    }
}