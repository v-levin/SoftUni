using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_November_05_Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cols = 2 * n + 3;
            var middleStarStart = n / 2;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{new string('*', i)}{new string('\\', 1)}{new string('-', cols - 2 * i - 2)}{new string('/', 1)}{new string('*', i)}");
            }

            for (int i = 1; i <= n / 3; i++)
            {
                Console.WriteLine($"{new string('|', 1)}{new string('*', middleStarStart)}{new string('\\', 1)}{new string('*', cols - 4 - 2 * middleStarStart)}{new string('/', 1)}{new string('*', middleStarStart)}{new string('|', 1)}");
                middleStarStart++;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{new string('-', i)}{new string('\\', 1)}{new string('*', cols - 2 * i - 2)}{new string('/', 1)}{new string('-', i)}");
            }
        }
    }
}
