using System;
using System.Collections.Generic;

namespace _05.Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var phonebook = new Dictionary<string, string>();

            while (!input.Equals("search"))
            {
                var inputParams = input.Split('-');
                var name = inputParams[0];
                var phoneNumber = inputParams[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook[name] = "";
                }

                phonebook[name] = phoneNumber;

                input = Console.ReadLine();
            }

            var nameToSearch = Console.ReadLine();

            while (!nameToSearch.Equals("stop"))
            {
                if (phonebook.ContainsKey(nameToSearch))
                {
                    Console.WriteLine($"{nameToSearch} -> {phonebook[nameToSearch]}");
                }
                else
                {
                    Console.WriteLine($"Contact {nameToSearch} does not exist.");
                }

                nameToSearch = Console.ReadLine();
            }
        }
    }
}
