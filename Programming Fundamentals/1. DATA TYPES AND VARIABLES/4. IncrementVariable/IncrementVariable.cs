using System;

namespace IncrementVariable
{
    class IncrementVariable
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            byte variable = 0;  // MAX VALUE == 255
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                variable++;

                if (variable == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"{variable}\nOverflowed {count} times");
        }
    }
}
