using System;
using System.Text.RegularExpressions;

namespace _7.ValidTime
{
    public class ValidTime
    {
        public static void Main()
        {
            var time = Console.ReadLine();

            var pattern = @"^(0[0-9]|1[0-2]):[0-5][0-9]:[0-5][0-9] [AP]M$";
            var regex = new Regex(pattern);

            while (time != "END")
            {
                var match = regex.Match(time);

                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                time = Console.ReadLine();
            }
        }
    }
}
