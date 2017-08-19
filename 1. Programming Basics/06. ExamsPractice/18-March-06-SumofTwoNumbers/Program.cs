using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_March_06_SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var intervalStart = int.Parse(Console.ReadLine());
            var intervalEnd = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var combinationExists = false;
            var sum = 0;
            var count = 0;

            for (int d1 = intervalStart; d1 <= intervalEnd; d1++)
            {
                for (int d2 = intervalStart; d2 <= intervalEnd; d2++)
                {
                    sum = d1 + d2;
                    count++;
                    if (sum == magicNumber)
                    {
                        combinationExists = true;
                        Console.WriteLine($"Combination N:{count} ({d1} + {d2} = {sum})");
                        break;
                    }

                }

                if (sum == magicNumber) break;
            }

            if (combinationExists == false)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }
    }
}
