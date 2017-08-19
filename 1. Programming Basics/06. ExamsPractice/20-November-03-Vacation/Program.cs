using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_November_03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfAdults = int.Parse(Console.ReadLine());
            var numberOfKids = int.Parse(Console.ReadLine());
            var numberOfNights = int.Parse(Console.ReadLine());
            var transportType = Console.ReadLine().ToLower();

            var totalSum = 0.0;

            if (transportType == "train")
            {
                if (numberOfAdults + numberOfKids >= 50)
                {
                    var adultsPrice = 24.99 * 0.50;
                    var kidsPrice = 14.99 * 0.50;
                    var transportPrice = (numberOfAdults * adultsPrice + numberOfKids * kidsPrice) * 2;
                    var hotelPrice = numberOfNights * 82.99;
                    var comission = (transportPrice + hotelPrice) * 0.10;
                    totalSum = transportPrice + hotelPrice + comission;
                }
                else
                {
                    var adultsPrice = 24.99;
                    var kidsPrice = 14.99;
                    var transportPrice = (numberOfAdults * adultsPrice + numberOfKids * kidsPrice) * 2;
                    var hotelPrice = numberOfNights * 82.99;
                    var comission = (transportPrice + hotelPrice) * 0.10;
                    totalSum = transportPrice + hotelPrice + comission;
                }
            }
            else if (transportType == "bus")
            {
                var adultsPrice = 32.50;
                var kidsPrice = 28.50;
                var transportPrice = (numberOfAdults * adultsPrice + numberOfKids * kidsPrice) * 2;
                var hotelPrice = numberOfNights * 82.99;
                var comission = (transportPrice + hotelPrice) * 0.10;
                totalSum = transportPrice + hotelPrice + comission;
            }
            else if (transportType == "boat")
            {
                var adultsPrice = 42.99;
                var kidsPrice = 39.99;
                var transportPrice = (numberOfAdults * adultsPrice + numberOfKids * kidsPrice) * 2;
                var hotelPrice = numberOfNights * 82.99;
                var comission = (transportPrice + hotelPrice) * 0.10;
                totalSum = transportPrice + hotelPrice + comission;
            }
            else if (transportType == "airplane")
            {
                var adultsPrice = 70.00;
                var kidsPrice = 50.00;
                var transportPrice = (numberOfAdults * adultsPrice + numberOfKids * kidsPrice) * 2;
                var hotelPrice = numberOfNights * 82.99;
                var comission = (transportPrice + hotelPrice) * 0.10;
                totalSum = transportPrice + hotelPrice + comission;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
