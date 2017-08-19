using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfNumbers = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 0; i < numberOfNumbers; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;                   
            }
            Console.WriteLine(sum);
        }
    }
}
