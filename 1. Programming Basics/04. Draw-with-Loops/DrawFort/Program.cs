using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string('/', 1));
            Console.Write(new string('^', n / 2));
            Console.Write(new string('\\', 1));
            Console.Write(new string('_', Math.Abs(2 * (n / 2 + 2) - 2 * n)));
            Console.Write(new string('/', 1));
            Console.Write(new string('^', n / 2));
            Console.WriteLine(new string('\\', 1));

            for (int row = 0; row < n - 3; row++)
            {
                Console.Write("|");
                Console.Write(new string(' ', 2 * n - 2));
                Console.WriteLine("|");
            }

            if (n > 4)
            {

                Console.Write("|");
                Console.Write(new string(' ', n / 2 + 1));
                Console.Write(new string('_', Math.Abs(2 * (n / 2 + 2) - 2 * n)));
                Console.Write(new string(' ', n / 2 + 1));
                Console.WriteLine("|");
            }
            else
            {
                Console.Write("|");
                Console.Write(new string(' ', 2 * n - 2));
                Console.WriteLine("|");
            }


            Console.Write(new string('\\', 1));
            Console.Write(new string('_', n / 2));
            Console.Write(new string('/', 1));
            Console.Write(new string(' ', Math.Abs(2 * (n / 2 + 2) - 2 * n)));
            Console.Write(new string('\\', 1));
            Console.Write(new string('_', n / 2));
            Console.Write(new string('/', 1));
        }
    }
}
