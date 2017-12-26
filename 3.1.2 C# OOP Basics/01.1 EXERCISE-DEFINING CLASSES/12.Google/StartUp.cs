using System;
using System.Collections.Generic;
using System.Linq;

namespace Google
{
    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                var personInfo = inputLine.Split();
                var personName = personInfo[0];

                Person person;
                if (people.Any(p => p.Name == personName))
                {
                    person = people.Where(p => p.Name == personName).Select(p => p).FirstOrDefault();
                    GetPersonInfo(personInfo, person);
                }
                else
                {
                    person = new Person(personName);
                    GetPersonInfo(personInfo, person);
                    people.Add(person);
                }
            }

            var name = Console.ReadLine();

            var personToPrint = people.Where(p => p.Name == name).FirstOrDefault();

            Console.WriteLine($"{personToPrint.ToString()}");
        }

        private static void GetPersonInfo(string[] personInfo, Person person)
        {
            var info = personInfo[1];

            switch (info)
            {
                case "company":
                    var companyName = personInfo[2];
                    var department = personInfo[3];
                    var salary = decimal.Parse(personInfo[4]);
                    person.Company = new Company(companyName, department, salary);
                    break;
                case "pokemon":
                    var pokemonName = personInfo[2];
                    var pokemonType = personInfo[3];
                    var pokemon = new Pokemon(pokemonName, pokemonType);
                    person.Pokemons.Add(pokemon);
                    break;
                case "parents":
                    var parentName = personInfo[2];
                    var parentBirthday = personInfo[3];
                    var parent = new Parent(parentName, parentBirthday);
                    person.Parents.Add(parent);
                    break;
                case "children":
                    var childName = personInfo[2];
                    var childBirthday = personInfo[3];
                    var child = new Child(childName, childBirthday);
                    person.Children.Add(child);
                    break;
                case "car":
                    var carModel = personInfo[2];
                    var carSpeed = int.Parse(personInfo[3]);
                    person.Car = new Car(carModel, carSpeed);
                    break;
            }
        }
    }
}
