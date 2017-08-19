using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;
            var p1Count = 0;
            var p2Count = 0;
            var p3Count = 0;
            var p4Count = 0;
            var p5Count = 0;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < 200)
                {
                    p1Count++;
                }
                else if (currentNumber >= 200 && currentNumber < 400)
                {
                    p2Count++;
                }
                else if (currentNumber >= 400 && currentNumber < 600)
                {
                    p3Count++;
                }
                else if (currentNumber >= 600 && currentNumber < 800)
                {
                    p4Count++;
                }
                else if (currentNumber >= 800)
                {
                    p5Count++;
                }
            }

            p1 = (double)p1Count / n * 100;
            p2 = (double)p2Count / n * 100;
            p3 = (double)p3Count / n * 100;
            p4 = (double)p4Count / n * 100;
            p5 = (double)p5Count / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
