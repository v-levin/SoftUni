using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethodStrings
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            List<Box<string>> listOfBoxes = new List<Box<string>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                Box<string> boxStr = new Box<string>(Console.ReadLine());
                listOfBoxes.Add(boxStr);
            }

            var element = Console.ReadLine();
            var result = GetGreaterElementsCount(listOfBoxes, element);

            Console.WriteLine(result);
        }

        public static int GetGreaterElementsCount<T>(List<Box<T>> listOfBoxes, T element)
            where T : IComparable
            => listOfBoxes.Count(x => x.Value.CompareTo(element) > 0);
    }
}
