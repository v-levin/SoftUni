using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.CommandInterpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            var seriesOfStrings = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var command = Console.ReadLine();

            while (command != "end")
            {
                var commandParams = command.Split();
                var action = commandParams[0];

                switch (action)
                {
                    case "reverse":
                        var reverseStart = int.Parse(commandParams[2]);
                        var reverseCount = int.Parse(commandParams[4]);

                        if (IsValid(seriesOfStrings, reverseStart, reverseCount))
                        {
                            Reverse(seriesOfStrings, reverseStart, reverseCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "sort":
                        var sortStart = int.Parse(commandParams[2]);
                        var sortCount = int.Parse(commandParams[4]);

                        if (IsValid(seriesOfStrings, sortStart, sortCount))
                        {
                            Sort(seriesOfStrings, sortStart, sortCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "rollLeft":
                        var rollLeftCount = int.Parse(commandParams[1]);

                        if (rollLeftCount >= 0)
                        {
                            RollLeft(seriesOfStrings, rollLeftCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "rollRight":
                        var rollRightCount = int.Parse(commandParams[1]);

                        if (rollRightCount >= 0)
                        {
                            RollRight(seriesOfStrings, rollRightCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", seriesOfStrings)}]");
        }

        private static bool IsValid(List<string> seriesOfStrings, int start, int count)
        {
            var result = start >= 0 && start < seriesOfStrings.Count && count >= 0 && (start + count) <= seriesOfStrings.Count;

            return result;
        }

        private static void Reverse(List<string> seriesOfStrings, int reverseStart, int reverseCount)
        {
            seriesOfStrings.Reverse(reverseStart, reverseCount);
        }

        private static void Sort(List<string> seriesOfStrings, int sortStart, int sortCount)
        {
            seriesOfStrings.Sort(sortStart, sortCount, null);
        }

        private static void RollLeft(List<string> seriesOfStrings, int rollLeftCount)
        {
            var rotations = rollLeftCount % seriesOfStrings.Count;

            for (int i = 0; i < rotations; i++)
            {
                var firstElement = seriesOfStrings[0];
                seriesOfStrings.RemoveAt(0);
                seriesOfStrings.Add(firstElement);
            }
        }

        private static void RollRight(List<string> seriesOfStrings, int rollRightCount)
        {
            var rotations = rollRightCount % seriesOfStrings.Count;

            for (int i = 0; i < rotations; i++)
            {
                var lastElement = seriesOfStrings[seriesOfStrings.Count - 1];
                seriesOfStrings.RemoveAt(seriesOfStrings.Count - 1);
                seriesOfStrings.Insert(0, lastElement);
            }
        }
    }
}
