using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividingWithoutResidue
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1Count = 0;
            var p2Count = 0;
            var p3Count = 0;
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0)
                {
                    p1Count++;
                }

                if (currentNumber % 3 == 0)
                {
                    p2Count++;
                }

                if (currentNumber % 4 == 0)
                {
                    p3Count++;
                }
            }

            p1 = (double)p1Count / n * 100;
            p2 = (double)p2Count / n * 100;
            p3 = (double)p3Count / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
