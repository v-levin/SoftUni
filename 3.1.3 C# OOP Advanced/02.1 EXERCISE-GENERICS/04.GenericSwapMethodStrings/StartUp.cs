using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
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

            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstIndex = indexes[0];
            var secondIndex = indexes[1];

            SwapElements(listOfBoxes, firstIndex, secondIndex);

            foreach (var box in listOfBoxes)
            {
                Console.WriteLine(box);
            }
        }

        private static void SwapElements<T>(List<T> listOfBoxes, int firstIndex, int secondIndex)
        {
            T tempBox = listOfBoxes[firstIndex];
            listOfBoxes[firstIndex] = listOfBoxes[secondIndex];
            listOfBoxes[secondIndex] = tempBox;
        }
    }
}
