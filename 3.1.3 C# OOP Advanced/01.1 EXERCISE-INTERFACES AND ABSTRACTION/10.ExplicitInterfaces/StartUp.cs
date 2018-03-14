using ExplicitInterfaces.Interfaces;
using System;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        public static void Main()
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                var tokens = inputLine.Split();
                var name = tokens[0];
                var country = tokens[1];
                var age = int.Parse(tokens[2]);

                Citizen citizen = new Citizen(name, country, age);
                IPerson person = citizen;
                IResident resident = citizen;

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
