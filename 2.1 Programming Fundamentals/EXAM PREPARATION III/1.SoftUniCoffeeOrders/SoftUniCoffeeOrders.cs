using System;
using System.Globalization;

namespace _1.SoftUniCoffeeOrders
{
    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            var countOfOrders = int.Parse(Console.ReadLine());

            var totalPrice = 0M;
            for (int i = 0; i < countOfOrders; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InstalledUICulture);
                var capsulesCount = int.Parse(Console.ReadLine());

                var month = orderDate.Month;
                var year = orderDate.Year;

                var daysInMonth = DateTime.DaysInMonth(year, month);

                var coffeePrice = ((daysInMonth * (long)capsulesCount) * pricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${coffeePrice:F2}");

                totalPrice += coffeePrice;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
