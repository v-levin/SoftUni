using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main()
        {
            var examStartHour = int.Parse(Console.ReadLine());
            var examStartMinute = int.Parse(Console.ReadLine());
            var arrivialHour = int.Parse(Console.ReadLine());
            var arrivialMinutes = int.Parse(Console.ReadLine());

            var late = arrivialHour == examStartHour && arrivialMinutes > examStartMinute || arrivialHour > examStartHour;
            var onTime = arrivialHour == examStartHour && arrivialMinutes >= examStartMinute - 30 && arrivialMinutes <= examStartMinute || arrivialHour == examStartHour - 1 && (60 - arrivialMinutes + examStartMinute) <= 30;
            var early = arrivialHour == examStartHour && arrivialMinutes < examStartMinute - 30 || arrivialHour == examStartHour - 1 && arrivialMinutes - examStartMinute < 30 || arrivialHour < examStartHour + 1;
            var minutes = 0;

            if (late)
            {
                Console.WriteLine("Late");

                if (arrivialHour == examStartHour)
                {
                    minutes = arrivialMinutes - examStartMinute;
                    Console.WriteLine($"{minutes} minutes after the start");
                }
                else if (arrivialMinutes < examStartMinute)
                {
                    minutes = 60 - examStartMinute + arrivialMinutes;
                    Console.WriteLine($"{minutes} minutes after the start");
                }
                else if (arrivialMinutes >= examStartMinute)
                {
                    minutes = arrivialMinutes - examStartMinute;
                    if (minutes < 10) Console.WriteLine($"{arrivialHour - examStartHour}:0{minutes} hours after the start");
                    else Console.WriteLine($"{arrivialHour - examStartHour}:{minutes} hours after the start");
                }
                
            }
            else if (onTime)
            {
                if (examStartHour == arrivialHour && examStartMinute == arrivialMinutes)
                {
                    Console.WriteLine("On time");
                }
                else if (arrivialHour == examStartHour)
                {
                    minutes = examStartMinute - arrivialMinutes;
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else
                {
                    minutes = 60 - arrivialMinutes + examStartMinute;
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            else if (early)
            {
                Console.WriteLine("Early");

                if (arrivialHour == examStartHour)
                {
                    minutes = examStartMinute - arrivialMinutes;
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else if (arrivialHour == examStartHour - 1 && arrivialMinutes > examStartMinute)
                {
                    minutes = 60 - arrivialMinutes + examStartMinute;
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else if (arrivialMinutes > examStartMinute)
                {
                    minutes = 60 - arrivialMinutes + examStartMinute;
                    if (minutes < 10) Console.WriteLine($"{examStartHour - arrivialHour - 1}:0{minutes} hours before the start");
                    else Console.WriteLine($"{examStartHour - arrivialHour - 1}:{minutes} hours before the start");
                }
                else if (arrivialMinutes <= examStartMinute)
                {
                    minutes = examStartMinute - arrivialMinutes;
                    if (minutes < 10) Console.WriteLine($"{examStartHour - arrivialHour}:0{minutes} hours before the start");
                    else Console.WriteLine($"{examStartHour - arrivialHour}:{minutes} hours before the start");
                }
            }

        }
    }
}