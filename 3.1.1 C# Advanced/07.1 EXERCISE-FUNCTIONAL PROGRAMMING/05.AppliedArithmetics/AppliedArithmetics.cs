using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    public class AppliedArithmetics
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    command = Console.ReadLine();
                    continue;
                }

                Func<int, int> applyArithmetics = GetArithmetics(command);
                numbers = numbers.Select(applyArithmetics).ToArray();

                command = Console.ReadLine();
            }
        }

        private static Func<int, int> GetArithmetics(string command)
        {
            switch (command)
            {
                case "add": return n => n + 1;
                case "multiply": return n => n * 2;
                case "subtract": return n => n - 1;
                default: return n => n;
            }
        }
    }
}
