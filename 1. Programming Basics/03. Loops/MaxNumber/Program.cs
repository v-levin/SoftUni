using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfNumbers = int.Parse(Console.ReadLine());
            var largestNumber = int.MinValue;

            for (int i = 0; i < numberOfNumbers; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (largestNumber < currentNumber)
                {
                    largestNumber = currentNumber;
                }
            }

            Console.WriteLine(largestNumber);
        }
    }
}
