using System;

namespace _3_PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);
            
        }

        public static void PrintTriangle(int end, int start = 1)
        {
            for (int i = start; i <= end; i++)
            {
                PrintLine(i);
            }

            for (int i = end - 1; i >= start; i--)
            {
                PrintLine(i);
            }
        }

        public static void PrintLine(int size, int start = 1)
        {
            for (int i = start; i <= size; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }


    }
}
