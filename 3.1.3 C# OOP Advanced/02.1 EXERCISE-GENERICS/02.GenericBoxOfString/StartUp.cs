using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                Box<string> boxStr = new Box<string>(Console.ReadLine());

                Console.WriteLine(boxStr);
            }
        }
    }
}
