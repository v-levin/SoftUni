using System;

namespace VolleyBall
{
    class Program
    {
        static void Main()
        {
            var leapOrNormal = Console.ReadLine().ToLower();
            var numberOfHolidays = int.Parse(Console.ReadLine());
            var weekendsInHometown = int.Parse(Console.ReadLine());

            var weekendsInYear = 48.0;
            double playsInSofia = (weekendsInYear - weekendsInHometown) * 3 / 4;
            var playsInHolidays = (double)numberOfHolidays * 2 / 3;
            var numberOfPlays = playsInSofia + weekendsInHometown + playsInHolidays;

            if (leapOrNormal == "leap")
            {
                var extraPlay = numberOfPlays * 15 / 100;
                Console.WriteLine(Math.Floor(numberOfPlays + extraPlay));
            }
            else
            {
                Console.WriteLine(Math.Floor(numberOfPlays));
            }

        }
    }
}