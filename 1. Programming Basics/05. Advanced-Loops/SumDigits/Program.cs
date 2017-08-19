using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lastDigit = 0;
            var sum = 0;

            while (n > 0)
            {
                lastDigit = n % 10;
                sum += lastDigit;
                n /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
