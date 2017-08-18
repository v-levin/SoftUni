using System;
using System.Globalization;

namespace DatePlus1000
{
    class Program
    {
        static void Main()
        {
            string startDate, format;
            format = "dd-MM-yyyy";
            startDate = Console.ReadLine();
            var datePlus1000Days = DateTime.ParseExact(startDate, format, CultureInfo.InvariantCulture).AddDays(999);
            Console.WriteLine(datePlus1000Days.ToString("dd-MM-yyyy"));
        }
    }
}