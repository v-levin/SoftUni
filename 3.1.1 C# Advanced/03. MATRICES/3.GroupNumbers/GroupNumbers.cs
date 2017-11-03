using System;
using System.Linq;

namespace _3.GroupNumbers
{
    public class GroupNumbers
    {
        public static void Main()
        {
            var matrix = new int[3][];

            var numbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            matrix[0] = numbers.Where(n => Math.Abs(n) % 3 == 0).ToArray();
            matrix[1] = numbers.Where(n => Math.Abs(n) % 3 == 1).ToArray();
            matrix[2] = numbers.Where(n => Math.Abs(n) % 3 == 2).ToArray();

            Console.WriteLine($"{string.Join(" ", matrix[0])}\n{string.Join(" ", matrix[1])}\n{string.Join(" ", matrix[2])}");
        }
    }
}
