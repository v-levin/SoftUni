using System;

namespace Cinema
{
    class Program
    {
        static void Main()
        {
            var typeOfProjection = Console.ReadLine().ToLower();
            var numberOfRows = int.Parse(Console.ReadLine());
            var numberOfColomns = int.Parse(Console.ReadLine());

            switch (typeOfProjection)
            {
                case "premiere":
                    Console.WriteLine($"{numberOfRows * numberOfColomns * 12.00:f2} leva");
                    break;
                case "normal":
                    Console.WriteLine($"{numberOfRows * numberOfColomns * 7.50:f2} leva");
                    break;
                case "discount":
                    Console.WriteLine($"{numberOfRows * numberOfColomns * 5.00:f2} leva");
                    break;
                default:
                    break;
            }
        }
    }
}