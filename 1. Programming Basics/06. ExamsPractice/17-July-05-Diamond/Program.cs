using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_July_05_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = 5 * n;

            Console.WriteLine($"{new string('.', n)}{new string('*', width - (2 * n))}{new string('.', n)}");

            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine($"{new string('.', n - i)}{new string('*', 1)}{new string('.', width - 2 * (n - i) - 2)}{new string('*', 1)}{new string('.', n - i)}");
            }

            Console.WriteLine(new string('*', width));

            for (int i = 1; i <= 2 * n + 1; i++)
            {
                if (i == 2 * n + 1)
                {
                    Console.WriteLine($"{new string('.', i)}{new string('*', width - 2 * i)}{new string('.', i)}");
                }
                else
                {
                    Console.WriteLine($"{new string('.', i)}{new string('*', 1)}{new string('.', width - 2 * i - 2)}{new string('*', 1)}{new string('.', i)}");
                }
            }
        }
    }
}
