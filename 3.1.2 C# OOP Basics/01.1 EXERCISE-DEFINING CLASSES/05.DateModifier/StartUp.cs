using System;

namespace DateModifier
{
    public class StartUp
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var dateModifier = new DateModifier();

            var result = dateModifier.CalculateDifference(firstDate, secondDate);

            Console.WriteLine(result);
        }
    }
}
