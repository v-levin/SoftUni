using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.MirrorImage
{
    class MirrorImage
    {
        static void Main()
        {
            var elements = Console.ReadLine()
                .Split()
                .ToList();

            var index = Console.ReadLine();

            while (!index.Equals("Print"))
            {
                var indexInt = int.Parse(index);

                ReverseLeft(elements, indexInt);
                ReverseRight(elements, indexInt);

                index = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", elements));
        }

        static void ReverseRight(List<string> elements, int indexInt)
        {
            for (int i = 1; i <= (elements.Count - 1 - indexInt) / 2; i++)
            {
                var temp = elements[indexInt + i];
                elements[indexInt + i] = elements[elements.Count - i];
                elements[elements.Count - i] = temp;
            }
        }

        static void ReverseLeft(List<string> elements, int indexInt)
        {
            for (int i = 0; i < indexInt / 2; i++)
            {
                var temp = elements[i];
                elements[i] = elements[indexInt - i - 1];
                elements[indexInt - i - 1] = temp;
            }
        }
    }
}
