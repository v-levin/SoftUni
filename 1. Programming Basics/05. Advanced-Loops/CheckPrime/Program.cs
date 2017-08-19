using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var isPrime = true;
            var sqrt = Math.Sqrt(n);

            if (n % 2 == 0 || n < 2)
            {
                isPrime = false;
            }

            for (int i = 3; i <= sqrt; i += 2)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime) Console.WriteLine("Prime");
            else Console.WriteLine("Not Prime");
        }
    }
}
