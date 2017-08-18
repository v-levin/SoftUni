using System;

namespace _1_HelloName_
{
    class HelloName
    {
        static void Main()
        {
            string name = Console.ReadLine();

            string greeting = GetName(name);

            Console.WriteLine(greeting);
        }

        static string GetName(string name)
        {
            string result = $"Hello, {name}!";

            return result;
        }
    }
}
