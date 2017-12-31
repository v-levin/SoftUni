using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var targetPersonInfo = Console.ReadLine();

        var people = new List<Person>();

        var parentChildInfo = new List<string>();
        var personInfo = new List<string>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            if (input.Contains('-'))
            {
                parentChildInfo.Add(input);
            }
            else
            {
                personInfo.Add(input);
            }
        }

        for (int i = 0; i < personInfo.Count; i++)
        {
            var personArgs = personInfo[i].Split();
            var name = $"{personArgs[0]} {personArgs[1]}";
            var birthday = personArgs[2];

            people.Add(new Person { Name = name, Birthday = birthday });
        }

        for (int i = 0; i < parentChildInfo.Count; i++)
        {
            Person parent = null;
            Person child = null;

            var parentChildArgs = parentChildInfo[i].Split('-').Select(s => s.Trim()).ToArray();

            if (parentChildArgs[0].Contains('/'))
            {
                var birthday = parentChildArgs[0];
                parent = people.First(p => p.Birthday == birthday);
            }
            else
            {
                var nameArgs = parentChildArgs[0].Split();
                var name = $"{nameArgs[0]} {nameArgs[1]}";

                parent = people.First(p => p.Name == name);
            }

            if (parentChildArgs[1].Contains('/'))
            {
                var birthday = parentChildArgs[1];
                child = people.First(p => p.Birthday == birthday);
            }
            else
            {
                var nameArgs = parentChildArgs[1].Split();
                var name = $"{nameArgs[0]} {nameArgs[1]}";

                child = people.First(p => p.Name == name);
            }

            parent.Children.Add(child);
            child.Parents.Add(parent);
        }

        Person targetPerson = null;

        if (targetPersonInfo.Contains('/'))
        {
            var birthday = targetPersonInfo;
            targetPerson = people.First(p => p.Birthday == birthday);
        }
        else
        {
            var name = targetPersonInfo;
            targetPerson = people.First(p => p.Name == name);
        }

        Console.WriteLine($"{targetPerson.Name} {targetPerson.Birthday}");
        Console.WriteLine("Parents:");
        foreach (var parent in targetPerson.Parents)
        {
            Console.WriteLine($"{parent.Name} {parent.Birthday}");
        }
        Console.WriteLine("Children:");
        foreach (var child in targetPerson.Children)
        {
            Console.WriteLine($"{child.Name} {child.Birthday}");
        }
    }
}
