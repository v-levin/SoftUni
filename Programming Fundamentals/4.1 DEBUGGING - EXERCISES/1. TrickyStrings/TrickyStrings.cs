using System;
class TrickyStrings
{
    static void Main(string[] args)
    {
        var delimiter = Console.ReadLine();
        var numberOfStrings = int.Parse(Console.ReadLine());

        string result = GetTrickyString(delimiter, numberOfStrings);

        Console.WriteLine(result);
    }

    private static string GetTrickyString(string delimiter, int numberOfStrings)
    {
        var result = string.Empty;
        var currentString = string.Empty;

        for (int i = 0; i < numberOfStrings; i++)
        {
            currentString = Console.ReadLine();
            result += currentString + delimiter;
        }

        result = result.Substring(0, result.Length - delimiter.Length);

        return result;
    }
}