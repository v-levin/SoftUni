using System;
using System.Collections.Generic;

namespace _5.UserLogins
{
    class UserLogins
    {
        public static void Main()
        {
            var usernamePassword = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (!input.Equals("login"))
            {
                var currentInput = input.Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var username = currentInput[0];
                var password = currentInput[1];

                if (!usernamePassword.ContainsKey(username))
                {
                    usernamePassword[username] = password;
                }

                usernamePassword[username] = password;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            int failedAttemptsCount = 0;

            while (!input.Equals("end"))
            {
                var currentInput = input.Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var username = currentInput[0];
                var password = currentInput[1];

                if (!usernamePassword.ContainsKey(username) || !usernamePassword[username].Equals(password))
                {
                    Console.WriteLine($"{username}: login failed");

                    failedAttemptsCount++;
                }
                else
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {failedAttemptsCount}");
        }
    }
}
