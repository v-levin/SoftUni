using System;
using System.Collections.Generic;

namespace _1.ShootListElements
{
    class ShootListElements
    {
        static void Main()
        {
            List<int> numbers = new List<int>();

            string inputLine = Console.ReadLine();

            int lastRemovedInt = int.MinValue;

            string output = string.Empty;

            while (!inputLine.Equals("stop"))
            {
                if (inputLine.Equals("bang"))
                {

                    if (numbers.Count == 0)
                    {
                        output = "nobody left to shoot! last one was {lastRemovedInt}";
                        break;
                    }

                    int sum = SumElements(numbers);
                    double average = (double)sum / numbers.Count;

                    ShotElement(numbers, average, ref lastRemovedInt);

                    DecrementElements(numbers);
                }
                else
                {
                    int number = int.Parse(inputLine);
                    numbers.Insert(0, number);
                }

                inputLine = Console.ReadLine();
            }

            if (numbers.Count > 0 && output.Equals(string.Empty))
            {
                Console.WriteLine($"survivors: {string.Join(" ", numbers)}");
            }
            else if (numbers.Count == 0 && output.Equals(string.Empty))
            {
                Console.WriteLine($"you shot them all. last one was {lastRemovedInt}");
            }
            else
            {
                Console.WriteLine($"nobody left to shoot! last one was {lastRemovedInt}");
            }
        }

        private static void DecrementElements(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }

        private static void ShotElement(List<int> numbers, double average, ref int lastRemovedInt)
        {

            if (numbers.Count == 1)
            {
                Console.WriteLine($"shot {numbers[0]}");
                lastRemovedInt = numbers[0];
                numbers.RemoveAt(0);
                return;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];

                if (currentNumber < average)
                {
                    Console.WriteLine($"shot {numbers[i]}");
                    lastRemovedInt = numbers[i];
                    numbers.RemoveAt(i);
                    break;
                }
            }
        }

        static int SumElements(List<int> numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
