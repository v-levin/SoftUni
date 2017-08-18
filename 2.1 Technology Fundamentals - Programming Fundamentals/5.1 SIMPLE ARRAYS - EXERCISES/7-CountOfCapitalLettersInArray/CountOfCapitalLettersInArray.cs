using System;
using System.Linq;

namespace _7_CountOfCapitalLettersInArray
{
    class CountOfCapitalLettersInArray
    {
        static void Main()
        {
            string[] strings = Console.ReadLine().Split(' ');

            int count = 0;

            foreach (var str in strings)
            {
                if (str.Length == 1)
                {
                    if (str.All(char.IsUpper))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
