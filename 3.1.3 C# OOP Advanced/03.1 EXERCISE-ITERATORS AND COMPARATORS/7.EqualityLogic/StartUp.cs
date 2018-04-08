using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class StartUp
    {
        public static void Main()
        {
            SortedSet<Person> sortedSetPeople = new SortedSet<Person>();
            HashSet<Person> hashSetPeople = new HashSet<Person>();

            int numOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPeople; i++)
            {
                var personTokens = Console.ReadLine().Split();
                var name = personTokens[0];
                var age = int.Parse(personTokens[1]);

                Person person = new Person(name, age);

                sortedSetPeople.Add(person);
                hashSetPeople.Add(person);
            }

            Console.WriteLine(sortedSetPeople.Count);
            Console.WriteLine(hashSetPeople.Count);
        }
    }
}
