using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                var personArgs = inputLine.Split();
                var name = personArgs[0];
                var age = int.Parse(personArgs[1]);
                var town = personArgs[2];

                Person person = new Person(name, age, town);

                people.Add(person);
            }

            var indexOfPersonToCompare = int.Parse(Console.ReadLine());
            Person personToCompare = people[indexOfPersonToCompare - 1];

            int equalPeople = people.Count(p => p.CompareTo(personToCompare) == 0);
            int notEqualPeople = people.Count(p => p.CompareTo(personToCompare) != 0);
            int totalPeple = people.Count;

            if (equalPeople > 1)
            {
                Console.WriteLine($"{equalPeople} {notEqualPeople} {totalPeple}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
