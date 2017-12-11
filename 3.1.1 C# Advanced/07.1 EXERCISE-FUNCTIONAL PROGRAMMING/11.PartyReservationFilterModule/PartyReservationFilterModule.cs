using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PartyReservationFilterModule
{
    public class PartyReservationFilterModule
    {
        public static void Main()
        {
            var people = Console.ReadLine().Split().ToList();
            var commands = Console.ReadLine().Split(';');

            var filters = new List<string>();

            while (commands[0] != "Print")
            {
                switch (commands[0])
                {
                    case "Add filter":
                        filters.Add($"{commands[1]} {commands[2]}");
                        break;
                    case "Remove filter":
                        filters.Remove($"{commands[1]} {commands[2]}");
                        break;
                    default:
                        break;
                }

                commands = Console.ReadLine().Split(';');
            }

            foreach (var filter in filters)
            {
                var filterCommands = filter.Split();

                switch (filterCommands[0])
                {
                    case "Starts":
                        people = people.Where(p => !p.StartsWith(filterCommands[2])).ToList();
                        break;
                    case "Ends":
                        people = people.Where(p => !p.EndsWith(filterCommands[2])).ToList();
                        break;
                    case "Length":
                        people = people.Where(p => p.Length != int.Parse(filterCommands[1])).ToList();
                        break;
                    case "Contains":
                        people = people.Where(p => !p.Contains(filterCommands[1])).ToList();
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", people));
        }
    }
}
