using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var row = (n + 1) / 2;
            var blocks = 0;

            if (n % 2 == 0)
            {
                blocks = n - 2;
            }
            else
            {
                blocks = n - 1;
            }

            for (int i = 1; i <= row; i++)
            {
                if (n % 2 == 0)
                {
                    Console.Write(new string('-', blocks / 2));
                    Console.Write(new string('*', 2 * i));
                    Console.Write(new string('-', blocks / 2));
                    blocks -= 2;
                }
                else
                {
                    Console.Write(new string('-', blocks / 2));
                    Console.Write(new string('*', 2 * i - 1));
                    Console.Write(new string('-', blocks / 2));
                    blocks -= 2;

                }
                Console.WriteLine();
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
        }
    }
}
