using System;

namespace HotelRoom
{
    class Program
    {
        static void Main()
        {
            var month = Console.ReadLine().ToLower();
            var numberOfNights = int.Parse(Console.ReadLine());
            var apartment = 0.0;
            var studio = 0.0;

            if (month == "may" || month == "october")
            {
                apartment = numberOfNights * 65;
                studio = numberOfNights * 50;

                if (numberOfNights > 7 && numberOfNights <= 14) studio -= studio * 5 / 100;
                else if (numberOfNights > 14)
                {
                    studio -= studio * 30 / 100;
                    apartment -= apartment * 10 / 100;
                }
            }
            else if (month == "june" || month == "september")
            {
                apartment = numberOfNights * 68.70;
                studio = numberOfNights * 75.20;

                if (numberOfNights > 14)
                {
                    studio -= studio * 20 / 100;
                    apartment -= apartment * 10 / 100;
                }
            }
            else if (month == "july" || month == "august")
            {
                apartment = numberOfNights * 77;
                studio = numberOfNights * 76;

                if (numberOfNights > 14) apartment -= apartment * 10 / 100;
            }

            Console.WriteLine($"Apartment: {apartment:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}