using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            var oddSum = 0.0;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;
            var evenSum = 0.0;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());

                if ((i + 1) % 2 == 0)
                {
                    evenSum += currentNumber;

                    if (evenMax < currentNumber)
                    {
                        evenMax = currentNumber;
                    }

                    if (evenMin > currentNumber)
                    {
                        evenMin = currentNumber;
                    }
                }
                else
                {
                    oddSum += currentNumber;

                    if (oddMax < currentNumber)
                    {
                        oddMax = currentNumber;
                    }

                    if (oddMin > currentNumber)
                    {
                        oddMin = currentNumber;
                    }
                }
            }

            if (oddMin == double.MaxValue)
            {
                Console.WriteLine($"OddSum={oddSum},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (evenMin == double.MaxValue)
            {
                Console.WriteLine($"OddSum={oddSum},");
                Console.WriteLine($"OddMin={oddMin},");
                Console.WriteLine($"OddMax={oddMax},");
                Console.WriteLine($"EvenSum={evenSum},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum},");
                Console.WriteLine($"OddMin={oddMin},");
                Console.WriteLine($"OddMax={oddMax},");
                Console.WriteLine($"EvenSum={evenSum},");
                Console.WriteLine($"EvenMin={evenMin},");
                Console.WriteLine($"EvenMax={evenMax}");
            }
        }
    }
}
