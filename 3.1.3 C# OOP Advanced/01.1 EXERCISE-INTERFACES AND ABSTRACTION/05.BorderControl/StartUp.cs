using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> persons = new List<Person>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                var inputTokens = inputLine.Split();
                if (inputTokens.Count() == 3)
                {
                    var citizenName = inputTokens[0];
                    var citizenAge = int.Parse(inputTokens[1]);
                    var citizenId = inputTokens[2];

                    var citizen = new Person(citizenName, citizenAge, citizenId);
                    persons.Add(citizen);
                }
                else
                {
                    var robotModel = inputTokens[0];
                    var robotId = inputTokens[1];

                    var robot = new Person(robotModel, robotId);
                    persons.Add(robot);
                }
            }

            var lastDigitsOfFakeId = Console.ReadLine();

            persons.Where(p => p.Id.EndsWith(lastDigitsOfFakeId)).Select(p => p.Id).ToList().ForEach(id => Console.WriteLine(id));
        }
    }
}
