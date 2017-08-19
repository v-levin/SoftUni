using System;
using System.Globalization;

namespace _1.DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            var dateAsText = Console.ReadLine();

            var date = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
