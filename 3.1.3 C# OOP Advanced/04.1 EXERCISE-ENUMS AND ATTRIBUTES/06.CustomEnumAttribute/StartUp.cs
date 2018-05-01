using System;

namespace CustomEnumAttribute
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            if (input == "Rank")
            {
                PrintAttribute(typeof(Rank));
            }
            else
            {
                PrintAttribute(typeof(Suit));
            }
        }

        private static void PrintAttribute(Type type)
        {
            var attributes = type.GetCustomAttributes(false);
            Console.WriteLine(attributes[0]);
        }
    }
}
