using System;
using System.Linq;

namespace _02_ArrayElementsEqualToTheirIndex
{
    class ArrayElementsEqualToTheirIndex
    {
        static void Main()
        {
            int[] arrNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                if (arrNumbers[i] == i)
                {
                    Console.Write($"{arrNumbers[i]} ");
                }
            }

            Console.WriteLine();
        }
    }
}
