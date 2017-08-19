using System;

namespace _6_Notifications
{
    class Notifications
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string result = Console.ReadLine().ToLower();

                if (result == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();

                    string showMessage = ShowSuccess(operation, message);

                    Console.Write(showMessage);
                }
                else if (result == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());

                    string showMessage = ShowError(operation, code);

                    Console.Write(showMessage);
                }
                else
                {
                    continue;
                }
            }
        }

        static string ShowSuccess(string operation, string message)
        {
            string result = $"Successfully executed { operation}.\n==============================\nMessage: {message}.\n";

            return result;
        }

        static string ShowError(string operation, int code)
        {
            string reason = string.Empty;

            if (code >= 0)
            {
                reason = "Invalid Client Data";
            }
            else
            {
                reason = "Internal System Failure";
            }

            string result = $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: {reason}.\n";

            return result;
        }
    }
}
