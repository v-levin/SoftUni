using System;

public class StartUp
{
    public static void Main()
    {
        var personCount = int.Parse(Console.ReadLine());

        var team = new Team("Exodus");

        for (int i = 0; i < personCount; i++)
        {
            var personInfo = Console.ReadLine().Split();
            var person = new Person(personInfo[0], personInfo[1], int.Parse(personInfo[2]), double.Parse(personInfo[3]));

            team.AddPlayer(person);
        }

        Console.WriteLine($"First team have {team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");
    }
}
