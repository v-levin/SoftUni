using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CalculateSequenceWithQueue
{
    public class CalculateSequenceWithQueue
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();
            queue.Enqueue(n);

            var s = n;
            var counter = 0;
            var skipCount = 0;

            while (counter < 49)
            {
                if (counter % 3 == 0)
                {
                    s = queue.Skip(skipCount).Take(1).ToArray()[0];
                    queue.Enqueue(s + 1);
                    skipCount++;
                }
                else if (counter % 3 == 1)
                {
                    queue.Enqueue(2 * s + 1);
                }
                else if (counter % 3 == 2)
                {
                    queue.Enqueue(s + 2);
                }

                counter++;
            }

            Console.WriteLine(string.Join(" ", queue));
        }
    }
}
