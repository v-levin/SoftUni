using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PoisonousPlants
{
    public class PoisonousPlants
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var days = new int[n];
            var plantsIndexStack = new Stack<int>();
            plantsIndexStack.Push(0);

            for (int i = 1; i < plants.Length; i++)
            {
                var maxDays = 0;

                while (plantsIndexStack.Count > 0 && plants[plantsIndexStack.Peek()] >= plants[i])
                {
                    maxDays = Math.Max(maxDays, days[plantsIndexStack.Pop()]);
                }

                if (plantsIndexStack.Count > 0)
                {
                    days[i] = maxDays + 1;
                }

                plantsIndexStack.Push(i);
            }

            Console.WriteLine(days.Max());
        }
    }
}
