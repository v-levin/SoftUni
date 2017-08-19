using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var oldB = b;

            while (b != 0)
            {
                b = a % oldB;
                a = oldB;
                oldB = b;
            }
            Console.WriteLine(a);
        }
    }
}
