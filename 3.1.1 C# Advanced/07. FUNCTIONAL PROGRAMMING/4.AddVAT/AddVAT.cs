using System;
using System.Linq;

namespace _4.AddVAT
{
    public class AddVAT
    {
        public static void Main()
        {
            Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n * 1.2)
                .ToList()
                .ForEach(n => Console.WriteLine($"{n:n2}"));
        }
    }
}
