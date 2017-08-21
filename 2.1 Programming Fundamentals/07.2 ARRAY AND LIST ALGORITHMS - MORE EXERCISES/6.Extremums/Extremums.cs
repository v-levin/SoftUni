using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Extremums
{
    class Extremums
    {
        static void Main()
        {
            var sequenceOfInt = Console.ReadLine()
                .Split()
                .ToList();

            var command = Console.ReadLine();

            int sum = 0;

            if (command.Equals("Max"))
            {
                for (int i = 0; i < sequenceOfInt.Count; i++)
                {
                    var currentInt = sequenceOfInt[i].ToList();

                    int intMax = GetMaxValue(currentInt);

                    sequenceOfInt[i] = intMax.ToString();

                    sum += int.Parse(sequenceOfInt[i]);
                }
            }
            else
            {
                for (int i = 0; i < sequenceOfInt.Count; i++)
                {
                    var currentInt = sequenceOfInt[i].ToList();

                    int intMin = GetMinValue(currentInt);

                    sequenceOfInt[i] = intMin.ToString();

                    sum += int.Parse(sequenceOfInt[i]);
                }
            }

            Console.WriteLine(string.Join(", ", sequenceOfInt));
            Console.WriteLine(sum);
        }

        static int GetMinValue(List<char> currentInt)
        {
            var intMin = int.MaxValue;

            for (int j = 0; j < currentInt.Count; j++)
            {
                var temp = currentInt[0];
                currentInt.RemoveAt(0);
                currentInt.Add(temp);

                int currentNumber = int.Parse(string.Join("", currentInt));

                if (currentNumber < intMin)
                {
                    intMin = currentNumber;
                }
            }

            return intMin;
        }

        static int GetMaxValue(List<char> currentInt)
        {
            var intMax = int.MinValue;

            for (int j = 0; j < currentInt.Count; j++)
            {
                var temp = currentInt[0];
                currentInt.RemoveAt(0);
                currentInt.Add(temp);

                int currentNumber = int.Parse(string.Join("", currentInt));

                if (currentNumber > intMax)
                {
                    intMax = currentNumber;
                }
            }

            return intMax;
        }
    }
}
