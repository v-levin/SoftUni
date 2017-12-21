using System;
using System.Reflection;

namespace OldestFamilyMember
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var personName = personInfo[0];
                var personAge = int.Parse(personInfo[1]);

                var person = new Person(personName, personAge);
                family.AddMember(person);
            }

            var oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
