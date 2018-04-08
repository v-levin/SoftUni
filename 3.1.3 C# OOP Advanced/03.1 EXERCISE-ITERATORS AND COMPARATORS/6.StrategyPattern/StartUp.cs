using StrategyPattern.Comparators;
using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class StartUp
    {
        public static void Main()
        {
            SortedSet<Person> peopleSortedByName = new SortedSet<Person>(new NameComparator());
            SortedSet<Person> peopleSortedByAge = new SortedSet<Person>(new AgeComparator());

            var numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var personArgs = Console.ReadLine().Split();
                var name = personArgs[0];
                var age = int.Parse(personArgs[1]);

                Person person = new Person(name, age);
                peopleSortedByName.Add(person);
                peopleSortedByAge.Add(person);
            }

            foreach (var person in peopleSortedByName)
            {
                Console.WriteLine(person);
            }

            foreach (var person in peopleSortedByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}
