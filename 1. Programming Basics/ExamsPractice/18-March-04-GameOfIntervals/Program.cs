using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_March_04_GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = 0.0;
            var count1to9 = 0.0;
            var count10to19 = 0.0;
            var count20to29 = 0.0;
            var count30to39 = 0.0;
            var count40to50 = 0.0;
            var countInvalidNumbers = 0.0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num >= 0 && num < 10)
                {
                    result += num * 0.2;
                    count1to9++;
                }
                else if (num >= 10 && num < 20)
                {
                    result += num * 0.3;
                    count10to19++;
                }
                else if (num >= 20 && num < 30)
                {
                    result += num * 0.4;
                    count20to29++;
                }
                else if (num >= 30 && num < 40)
                {
                    result += 50;
                    count30to39++;
                }
                else if (num >= 40 && num <= 50)
                {
                    result += 100;
                    count40to50++;
                }
                else
                {
                    result /= 2;
                    countInvalidNumbers++;
                }
            }

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {count1to9 / n * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {count10to19 / n * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {count20to29 / n * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {count30to39 / n * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {count40to50 / n * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {countInvalidNumbers / n * 100:f2}%");
        }
    }
}
