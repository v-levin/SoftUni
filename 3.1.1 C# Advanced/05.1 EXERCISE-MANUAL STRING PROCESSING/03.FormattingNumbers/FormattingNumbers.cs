using System;

namespace _03.FormattingNumbers
{
    public class FormattingNumbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var a = int.Parse(nums[0]);
            var aHex = a.ToString("X").PadRight(10);
            var aBin = Convert.ToString(a, 2).PadLeft(10, '0').Substring(0, 10);
            var b = double.Parse(nums[1]).ToString("f2").PadLeft(10);
            var c = double.Parse(nums[2]).ToString("f3").PadRight(10);

            Console.WriteLine($"|{aHex}|{aBin}|{b}|{c}|");
        }
    }
}
