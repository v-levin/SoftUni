using System;
using System.Linq;

namespace _1.TakeTwo
{
    public class TakeTwo
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers
                .Where(n => n >= 10 && n <= 20)
                .Distinct()
                .Take(2)
                .ToList()
                .ForEach(n => Console.Write(n + " "));

        }
    }
}
