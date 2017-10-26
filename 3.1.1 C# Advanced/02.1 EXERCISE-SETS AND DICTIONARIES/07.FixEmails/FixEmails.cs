using System;
using System.Collections.Generic;

namespace _07.FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var emails = new Dictionary<string, string>();

            while (!input.Equals("stop"))
            {
                var name = input;
                var email = Console.ReadLine();
                var emailParams = email.Split('.');
                var domain = emailParams[emailParams.Length - 1];

                if (!domain.Equals("us") && !domain.Equals("uk"))
                {
                    emails.Add(name, email);
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in emails)
            {
                var name = kvp.Key;
                var email = kvp.Value;

                Console.WriteLine($"{name} -> {email}");
            }
        }
    }
}
