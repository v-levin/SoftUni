using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    public class PredicateParty
    {
        public static void Main()
        {
            var people = Console.ReadLine().Split().ToList();
            var command = Console.ReadLine().Split();
            
            while (command[0] != "Party!")
            {
                switch (command[1])
                {
                    case "StartsWith":
                        ExecuteCommandOnGuest(command[0], people, p => p.StartsWith(command[2]));
                        break;
                    case "EndsWith":
                        ExecuteCommandOnGuest(command[0], people, p => p.EndsWith(command[2]));
                        break;
                    case "Length":
                        ExecuteCommandOnGuest(command[0], people, p => p.Length == int.Parse(command[2]));
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split();
            }

            if (people.Any())
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void ExecuteCommandOnGuest(string command, List<string> people, Func<string, bool> condition)
        {
            for (int i = people.Count - 1; i >= 0; i--)
            {
                if (condition(people[i]))
                {
                    switch (command)
                    {
                        case "Double":
                            people.Insert(i, people[i]);
                            break;
                        case "Remove":
                            people.RemoveAt(i);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
