namespace _2.SoftUniParty
{
    using System;
    using System.Collections.Generic;

    public class SoftUniParty
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var questsReservations = new SortedSet<string>();

            while (!input.Equals("PARTY"))
            {
                questsReservations.Add(input);

                input = Console.ReadLine();
            }

            while (!input.Equals("END"))
            {
                questsReservations.Remove(input);

                input = Console.ReadLine();
            }

            Console.WriteLine(questsReservations.Count);
            Console.WriteLine(string.Join(Environment.NewLine, questsReservations));
        }
    }
}
