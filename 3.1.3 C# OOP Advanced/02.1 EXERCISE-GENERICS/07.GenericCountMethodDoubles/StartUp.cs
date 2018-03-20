using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethodDoubles
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            List<Box<double>> listOfBoxes = new List<Box<double>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                Box<double> boxStr = new Box<double>(double.Parse(Console.ReadLine()));
                listOfBoxes.Add(boxStr);
            }

            var element = double.Parse(Console.ReadLine());
            var result = GetGreaterElementsCount(listOfBoxes, element);

            Console.WriteLine(result);
        }

        public static double GetGreaterElementsCount<T>(List<Box<T>> listOfBoxes, T element)
            where T : IComparable
            => listOfBoxes.Count(x => x.Value.CompareTo(element) > 0);
    }
}
