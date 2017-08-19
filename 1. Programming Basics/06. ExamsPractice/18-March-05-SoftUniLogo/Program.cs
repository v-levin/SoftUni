using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_March_05_SoftUniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 12 * n - 5;
            var hat = 1;
            var row = 1;

            for (int i = 0; i < 2 * n - 1; i++)
            {
                Console.WriteLine($"{new string('.', width / 2)}{new string('#', hat)}{new string('.', width / 2)}");
                hat += 6;
                width -= 6;
                row++;
            }

            Console.WriteLine($"{new string('#', hat)}");
            row++;
            hat -= 6;
            width = 12 * n - 5;

            for (int j = 0; j < 2 * n - 2; j++)
            {
                if (j < n - 2)
                {
                    Console.WriteLine($"{new string('|', 1)}{new string('.', (width - hat) / 2 - 1)}{new string('#', hat)}{new string('.', (width - hat) / 2)}");
                    hat -= 6;
                    row++;
                }
                else if (row == 4 * n - 2)
                {
                    Console.WriteLine($"{new string('@', 1)}{new string('.', (width - hat) / 2 - 1)}{new string('#', hat)}{new string('.', (width - hat) / 2)}");
                }
                else
                {
                    Console.WriteLine($"{new string('|', 1)}{new string('.', (width - hat) / 2 - 1)}{new string('#', hat)}{new string('.', (width - hat) / 2)}");
                    row++;
                }
            }
        }
    }
}
