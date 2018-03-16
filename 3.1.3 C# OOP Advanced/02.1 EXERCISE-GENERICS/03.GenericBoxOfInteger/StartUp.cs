using System;

namespace GenericBoxOfInteger
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                Box<int> boxInt = new Box<int>(int.Parse(Console.ReadLine()));

                Console.WriteLine(boxInt);
            }
        }
    }
}
