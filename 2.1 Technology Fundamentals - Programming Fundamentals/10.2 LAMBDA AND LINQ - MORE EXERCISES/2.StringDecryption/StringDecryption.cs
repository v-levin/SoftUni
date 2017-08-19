using System;
using System.Linq;

namespace _2.StringDecryption
{
    public class StringDecryption
    {
        public static void Main()
        {
            var integers = Console.ReadLine().Split();
            var m = int.Parse(integers[0]);
            var n = int.Parse(integers[1]);

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var result =  numbers.Where(x => x > 64 && x < 91).Skip(m).Take(n).Select(x => (char)x).ToList();

            Console.WriteLine(string.Join("", result));
        }
    }
}
