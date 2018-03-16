using System;

namespace GenericBox
{
    public class StartUp
    {
        public static void Main()
        {
            Box<int> boxInt = new Box<int>(int.Parse(Console.ReadLine()));
            Box<string> boxStr = new Box<string>(Console.ReadLine());

            Console.WriteLine(boxInt);
            Console.WriteLine(boxStr);
        }
    }
}
