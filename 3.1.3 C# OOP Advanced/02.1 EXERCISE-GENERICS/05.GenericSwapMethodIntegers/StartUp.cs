using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethodIntegers
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            List<Box<int>> listOfBoxes = new List<Box<int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                Box<int> boxInt = new Box<int>(int.Parse(Console.ReadLine()));
                listOfBoxes.Add(boxInt);
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
