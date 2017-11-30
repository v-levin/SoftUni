using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var phoneNumber = Console.ReadLine();

            var pattern = @"^\+359( |-)2\1\d{3}\1\d{4}$";
            var regex = new Regex(pattern);

            while (phoneNumber != "end")
            {
                var match = regex.Match(phoneNumber);

                if (match.Success)
                {
                    Console.WriteLine(match);
                }

                phoneNumber = Console.ReadLine();
            }
        }
    }
}
