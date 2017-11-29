using System;
using System.Text.RegularExpressions;

namespace _6.ValidUsernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"^[\w-]{3,16}$";
            var regex = new Regex(pattern);

            while (input != "END")
            {
                var isMatch = regex.IsMatch(input);

                if (isMatch)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();
            }
        }
    }
}
