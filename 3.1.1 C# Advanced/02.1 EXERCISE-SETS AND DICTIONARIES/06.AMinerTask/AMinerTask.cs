using System;
using System.Collections.Generic;

namespace _06.AMinerTask
{
    public class AMinerTask
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var minerTasks = new Dictionary<string, int>();

            while (!input.Equals("stop"))
            {
                var resource = input;
                var quantity = int.Parse(Console.ReadLine());

                if (minerTasks.ContainsKey(input))
                {
                    minerTasks[input] += quantity;
                }
                else
                {
                    minerTasks.Add(input, quantity);
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in minerTasks)
            {
                var minerResource = kvp.Key;
                var quantity = kvp.Value;

                Console.WriteLine($"{minerResource} -> {quantity}");
            }
        }
    }
}
