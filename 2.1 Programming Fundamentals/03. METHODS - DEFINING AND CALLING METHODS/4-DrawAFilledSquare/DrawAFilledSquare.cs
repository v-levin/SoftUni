using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintFilledSquare(n);
        }

        private static void PrintFilledSquare(int n)
        {
            PrintHeader(n);

            for (int i = 0; i < n - 2; i++)
            {
                PrintBody(n);
            }

            PrintHeader(n);
        }

        private static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        private static void PrintBody(int n)
        {
            string body = "-";

            for (int i = 0; i < n - 1; i++)
            {
                body += @"\/";
            }

            body += "-";

            Console.WriteLine(body);
        }
    }
}
