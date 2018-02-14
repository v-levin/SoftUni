using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private bool isRunning;
    private NationsBuilder nationsBuilder;

    public Engine()
    {
        this.isRunning = true;
        this.nationsBuilder = new NationsBuilder();
    }

    public void Run()
    {
        while (this.isRunning)
        {
            var inputCommand = this.ReadInput();
            var commandParams = this.ParseInput(inputCommand);
            this.DistributeCommand(commandParams);
        }
    }

    private void DistributeCommand(List<string> commandParams)
    {
        var command = commandParams[0];
        commandParams.Remove(command);

        switch (command)
        {
            case "Bender":
                this.nationsBuilder.AssignBender(commandParams);
                break;
            case "Monument":
                this.nationsBuilder.AssignMonument(commandParams);
                break;
            case "Status":
                var status = this.nationsBuilder.GetStatus(commandParams[0]);
                this.OutputWriter(status);
                break;
            case "War":
                this.nationsBuilder.IssueWar(commandParams[0]);
                break;
            case "Quit":
                var record = this.nationsBuilder.GetWarsRecord();
                this.OutputWriter(record);
                this.isRunning = false;
                break;
        }
    }

    private string ReadInput()
    {
        return Console.ReadLine();
    }

    private List<string> ParseInput(string inputCommand)
    {
        return inputCommand.Split().ToList();
    }

    private void OutputWriter(string status) => Console.WriteLine(status);
}
