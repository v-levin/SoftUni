using System;
using System.Linq;

namespace _2.Ladybugs
{
    public class Ladybugs
    {
        public static void Main()
        {
            var sizeOfField = int.Parse(Console.ReadLine());
            var field = new long[sizeOfField];
            var indexesOfLadybugs = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            
            foreach (var index in indexesOfLadybugs)
            {
                if (index < 0 || index >= sizeOfField)
                {
                    continue;
                }

                field[index] = 1;
            }


            while (true)
            {
                var command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                var commandParams = command.Split();
                var currentLadybugIndex = int.Parse(commandParams[0]);
                var direction = commandParams[1];
                var flyLength = int.Parse(commandParams[2]);

                if (currentLadybugIndex < 0 || currentLadybugIndex >= sizeOfField)
                {
                    continue;
                }

                if (field[currentLadybugIndex] == 0)
                {
                    continue;
                }

                field[currentLadybugIndex] = 0;
                var position = currentLadybugIndex;

                while (true)
                {
                    if (direction == "right")
                    {
                        position += flyLength;
                    }
                    else if (direction == "left")
                    {
                        position -= flyLength;
                    }

                    if (position < 0 || position >= sizeOfField)
                    {
                        break;
                    }

                    if (field[position] == 0)
                    {
                        field[position] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
