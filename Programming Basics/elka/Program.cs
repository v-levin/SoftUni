using System;

namespace elka
{
    class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(new string(' ', num - i) + new string('*', i) + "|" + new string('*', i));
            }
        }
    }
}