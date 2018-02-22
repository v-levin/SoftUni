using System;

namespace Ferrari
{
    public class StartUp
    {
        public static void Main()
        {
            var driverName = Console.ReadLine();
            var ferrari = new Ferrari(driverName);

            Console.WriteLine($"{ferrari.Model}/{ferrari.Brake()}/{ferrari.Accelerate()}/{ferrari.DriverName}");
        }
    }
}
