using System;
using System.Linq;

namespace _1.ArrayContainsElement
{
    class ArrayContainsElement
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var num = int.Parse(Console.ReadLine());

            var checkIfNotExcists = true;

            foreach (var number in numbers)
            {
                if (number == num)
                {
                    Console.WriteLine("yes");
                    checkIfNotExcists = false;
                    break;
                }
            }

            if (checkIfNotExcists)
            {
                Console.WriteLine("no");
            }
        }
    }
}
